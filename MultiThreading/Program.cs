using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts1 = new ThreadStart(sendmails);
            Thread th1 = new Thread(ts1);

            ThreadStart ts2 = new ThreadStart(recievemails);
            Thread th2 = new Thread(ts2);

            th1.Start();
            th2.Start();
           // sendmails();
            //recievemails();

        }
        public static void sendmails()
        {
            for(int n=0;n<10;n++)
            {
                Console.WriteLine("sending mail "+n);
            }
        }
        public static void recievemails()
        {
            for (int n = 0; n < 10; n++)
            {
                Console.WriteLine("recieveing mail " + n);
            }
        }
    }
}
