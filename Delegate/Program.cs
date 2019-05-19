using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate int SignatureGetIntReturnNumber(int x, int y);
        static SignatureGetIntReturnNumber method2;
        static int Add(int x, int y)
        {
            int z = x + y;
            return z;
        }
        static int Multiply(int x, int y)
        {
            int z = x * y;
            return z; 
        }
        static int div(int x, int y)
        {
            int z = x / y;
            return z;
        }
        static int sub(int x, int y)
        {
            int z;
            if (x < y)
            
                z = y - x;
           else
                z = x - y;
            
            return z; 
        }
        static int Calculator (SignatureGetIntReturnNumber func, int x, int y)
        {
            return func.Invoke(x, y);
        }

        static void Main(string[] args)
        {
            int x = 4;
            int y = 8;
            method2 = Add;
            Console.WriteLine(Calculator(method2, 3,5));
            method2 = Multiply;
            Console.WriteLine(Calculator(method2, 3, 5));
            method2 = div;
            Console.WriteLine(Calculator(method2, 3, 5));
            method2 = sub;
            Console.WriteLine(Calculator(method2, 3, 5));

            
            Console.WriteLine(Calculator( ( n1,  n2) => (int)Math.Pow(n1, n2), x, y));
            Console.WriteLine(Calculator((n1, n2) => (int)Math.Pow(n1,(1*1.0)/n2), x, y));
      
            Func<int, int, int> add = Add;


            VideoEncoder encoder = new VideoEncoder() ;
            Video myDrivingVideo = new Video() { Title = " i am driving for the first time!" };

            EmileSender myEmailSender = new EmileSender();
            encoder.TheAfterFunction = myEmailSender.SendEmail;

            MessageWhatsapp whatsapp = new MessageWhatsapp();
            encoder.TheAfterFunction += whatsapp.SendWhatsapp;

            encoder.Encode(myDrivingVideo);
            Console.ReadLine();
            Console.WriteLine(encoder.TheAfterFunction);

        }

    }
}
