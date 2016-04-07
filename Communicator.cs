using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LoggerLib;
//using LogLib;

namespace AsynchronousChatLib
{
    /// <summary>
    /// Class that has communication functions.
    /// </summary>
    public class Communicator
    {
        private TcpClient client = null;
        public event MessageReceivedHandler MessageReceived; //value here is Null.
        private Thread workerThread; //New Thread used to listen for messages.
        public bool isConnected = false; //connection state
        ILoggingService logger; //to log to file.

        /// <summary>
        /// Constructor for Communicator
        /// that takes in an ILoggingService as a parameter.
        /// </summary>
        /// <param name="logger"></param>
        public Communicator(ILoggingService logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Method to spawn new thread that listens for messages.
        /// </summary>
        /// <param name="client">TCP Client passed in.</param>
        protected void Connect(TcpClient client)
        {
            this.client = client;
            //starts a new thread to listen for messages.
            workerThread = new Thread(ListenForMessages);
            workerThread.Name = "MyWorkerThread";
            isConnected = true;
            logger.Log(DateTime.Now.ToString() + " - Client Connected to Server.");
            workerThread.Start();
        }

        /// <summary>
        /// Listens for messages. 
        /// Checks for data available for received messages.
        /// </summary>
        private void ListenForMessages()
        {
            try
            {
                while (isConnected)
                { 
                    if (IsDataAvailable)
                    {
                        String message = ReceiveMessage();
                        if (MessageReceived != null)
                            MessageReceived(this, new MessageReceivedEventArgs(message));
                    }
                }
            }
            catch(Exception)
            {
                isConnected = false;
            }
           
        }

        /// <summary>
        /// Receives data from the Communicator
        /// </summary>
        /// <returns>the data received</returns>
        private String ReceiveMessage()
        {
            // Buffer for reading data
            Byte[] bytes = new Byte[256];
            String data = null;

            // Get a stream object for reading and writing
            NetworkStream stream = client.GetStream();   

            int count;
            do
            {
                // Loop to receive all the data sent by the client.
                if ((count = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    data += System.Text.Encoding.ASCII.GetString(bytes, 0, count);
                }
            } while (stream.DataAvailable);

            logger.Log(DateTime.Now.ToString() + " - Server: " + data); //Logs to file
            return data;
        }

        /// <summary>
        /// Receives messages from the communicator.
        /// </summary>
        /// <param name="data">data to be sent</param>
        public void SendMessage(String data)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
            NetworkStream stream = client.GetStream();
            stream.Write(msg, 0, msg.Length);
            logger.Log(DateTime.Now.ToString() + " - Client: " + data); //Logs to file
        }

        /// <summary>
        /// Checks to see if there is any data in the NetworkStream
        /// </summary>
        /// <returns>true if dataAvailable and false if not</returns>
        public bool IsDataAvailable
        {
            get
            {
                return client.GetStream().DataAvailable;
            }
        }

        /// <summary>
        /// Closes the Client Connection. Joins threads.
        /// Logs the Disconnected prompt to the log file.
        /// </summary>
        public virtual void CloseConnection()
        {
            //Logs that the end of the chat session is reached.
            logger.Log(DateTime.Now.ToString() + " - " + "Client disconnected. Chat Session ended.");
            

            if (workerThread != null)
            {
                isConnected = false;
                workerThread.Join(); //waits for the workerThread to complete before continuing.
                client.Close();
            }
        }
    }
}
