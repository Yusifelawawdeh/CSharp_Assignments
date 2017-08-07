using System;

namespace EventsAndDelegatesLearning
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: Mail Sending...");
        }
    }
}