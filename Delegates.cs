namespace AsynchronousChatLib
{
    /// <summary>
    /// Delegate used to handle when listening for messages received..
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void MessageReceivedHandler(object sender, MessageReceivedEventArgs e);

}