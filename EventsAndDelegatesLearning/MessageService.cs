using System;

namespace EventsAndDelegatesLearning
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source, EventArgs e)
        {
            Console.WriteLine("Message Service: Sending message...");
        }
    }
}