using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegatesLearning
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }    
    }

    public class VideoEncoder
    {
        //1- Define a delegate
        //2- define an event based on delegate
        //3- raise the event

        //public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);

        //eventHandler
        //eventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){ Video = video});
        }
    }
}
