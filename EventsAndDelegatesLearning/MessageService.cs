using System;

namespace EventsAndDelegatesLearning
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending message..." + args.Video.Title);
        }
    }
}