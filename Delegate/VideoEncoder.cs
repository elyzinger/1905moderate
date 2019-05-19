using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Delegate
{
    class VideoEncoder
    {

        //public delegate void MyActionVideo(Video v);
       // public MyActionVideo TheAfterFunction { get; set; }
            public Action<Video> TheAfterFunction { get; set; }

        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding{video.Title}" );
            Thread.Sleep(3000);
            //Console.WriteLine("sending email...");

            //Console.WriteLine("sending message..");
            if (TheAfterFunction  != null)
            {
                TheAfterFunction.Invoke(video);
            }

            

        }
    }
}
