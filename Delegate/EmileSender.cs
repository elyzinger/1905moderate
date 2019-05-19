using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class EmileSender
    {
        public void  SendEmail(Video video)
        {
            Console.WriteLine($"sending email for complition  of video {video.Title}  ");
        }
    }
}
