using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AsynchronousChatLib;
using LoggerLib;
using LogLib;


namespace AsynchronousChatUI
{
    
    public partial class Form_NetworkGame : Form
    {
        private const String serverIp = "127.0.0.1";
        private const Int32 port = 13000;
        Communicator communicator = null;
        private Client client;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form_NetworkGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dependencies injected via constructor.
        /// </summary>
        /// <param name="client"></param>
        public Form_NetworkGame(Client client) :this()
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new client and connects to server.
        /// </summary>
        /// <returns></returns>
        private Client CreateClient()
        {
            client.MessageReceived += HandleNewMessage;
            client.ConnectToServer(serverIp, port); //makes a new thread.
            return client;
        }

        /// <summary>
        /// Handles writing message to textbox from the new thread.
        /// Prevents Cross-thread scenarios. Tells the "main thread" to execute this
        /// if the Invoke is required.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">Event Args</param>
        private void HandleNewMessage(object sender, MessageReceivedEventArgs e) //event listener
        {
            if (this.textBoxConversation.InvokeRequired)
            {
                MessageReceivedHandler handler = new MessageReceivedHandler(HandleNewMessage);
                this.BeginInvoke(handler, new object[] { sender, e });
            }
            else
            {
                this.textBoxConversation.AppendText(e.Message);
                this.textBoxConversation.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Creates the new client and clears the Conversation textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                communicator = CreateClient(); //run as client
                textBoxConversation.Clear();
                connectToolStripMenuItem.Enabled = false;
                disconnectToolStripMenuItem.Enabled = true;
                buttonSend.Enabled = true;
            }
            catch(Exception)
            {
                //Displays an Error Message to the user.
                MessageBox.Show("Connection could not be Established.");
            }
        }

        /// <summary>
        /// Sends the message to the Server.
        /// Appends messages to the Conversation TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                communicator.SendMessage(textBoxTypeMessages.Text);
                textBoxConversation.AppendText(">>" + textBoxTypeMessages.Text);
                textBoxConversation.AppendText(Environment.NewLine);
                textBoxTypeMessages.Clear();
            }
            catch(Exception x)
            {
                //Displays an Error Message to the user
                //Disables Send button and Disconnect Menu Item
                //Enables Connect Button.
                if (!communicator.isConnected)
                {
                    MessageBox.Show("Connection Lost.");
                    buttonSend.Enabled = false;
                    connectToolStripMenuItem.Enabled = true;
                    disconnectToolStripMenuItem.Enabled = false;
                }
                else
                    MessageBox.Show(x.Message);
            }
        }

        /// <summary>
        /// Disconnects from the server.
        /// Enables/Disables UI elements</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            communicator.CloseConnection();
            connectToolStripMenuItem.Enabled = true;
            buttonSend.Enabled = false;
            disconnectToolStripMenuItem.Enabled = false;
            textBoxConversation.Text = "Disconnected."; 
        }

        /// <summary>
        /// Exits the Program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Disconnects from Server and then closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_NetworkGame_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if(communicator != null && communicator.isConnected)
                communicator.CloseConnection();
        }


        private void Form_NetworkGame_Load(object sender, EventArgs e){}
    }
}
