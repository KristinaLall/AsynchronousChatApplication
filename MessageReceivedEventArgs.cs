using System;


namespace AsynchronousChatLib
{
    public class MessageReceivedEventArgs:EventArgs
    {
        /// <summary>
        /// This is the Event Args that gets called if a message
        /// was received.
        /// </summary>
        /// <param name="message">Message Received</param>
        public MessageReceivedEventArgs(String message)
        {
            Message = message;
        }

        /// <summary>
        /// Getter for Message.
        /// </summary>
        public String Message { get; } 
    }
}
