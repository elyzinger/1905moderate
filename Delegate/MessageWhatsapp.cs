using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class MessageWhatsapp
    {
        public void SendWhatsapp (Video video)
        {
            Console.WriteLine($"sending whats..... for complition of {video.Title}");
        }
    }
}
