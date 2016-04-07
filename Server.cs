using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using LoggerLib;
//using LogLib;

namespace AsynchronousChatLib
{
    /// <summary>
    /// Server Class that inherits from Communicator Class.
    /// </summary>
    public class Server : Communicator
    {
        TcpListener server = null;

        /// <summary>
        /// Constructor for Server
        /// </summary>
        /// <param name="logger"></param>
        public Server(ILoggingService logger): base(logger)
        {

        }

        /// <summary>
        /// Starts the Server
        /// </summary>
        /// <param name="serverIp">Ip address to connect</param>
        /// <param name="port">Port number that server connects to</param>
        public void StartServer(String serverIp, Int32 port)
        {
            IPAddress localAddr = IPAddress.Parse(serverIp);
            server = new TcpListener(localAddr, port);

            // Start listening for client requests.
            server.Start();
        }

        /// <summary>
        /// Listens for connection from client.
        /// </summary>
        public void ListenForConnection()
        {
            // Perform a blocking call to accept requests.
            Connect(server.AcceptTcpClient());
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public override void CloseConnection()
        {
            base.CloseConnection();

            //Stop listening for client requests.
            server.Stop();
        }
    }

}

