using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using LoggerLib;
//using LogLib;

namespace AsynchronousChatLib
{
    /// <summary>
    /// Client class that inherits from Communicator
    /// </summary>
    public class Client : Communicator
    {

        /// <summary>
        /// Constructor for Client.
        /// </summary>
        /// <param name="logger"></param>
        public Client(ILoggingService logger) : base(logger)
        {

        }
        /// <summary>
        /// Connects to the server
        /// </summary>
        /// <param name="server">the server to connect to</param>
        /// <param name="port">the port number to connect to</param>
        public void ConnectToServer(String server, Int32 port)
        {
            // Create a TcpClient.
            Connect(new TcpClient(server, port));
        }

    }
}
