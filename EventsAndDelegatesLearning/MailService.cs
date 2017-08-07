using System;

namespace EventsAndDelegatesLearning
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Mail Sending..." + e.Video.Title);
        }
    }
}