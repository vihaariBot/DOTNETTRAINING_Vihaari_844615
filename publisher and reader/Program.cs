using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisher_and_reader_handson
{
    class Program
    {
        static void Main(string[] args)
        {
            reader[] rarr = new reader[5];

            rarr[0] = new reader();
            rarr[0].readername = "john";

            rarr[1] = new reader();
            rarr[1].readername = "marry";

            rarr[2] = new reader();
            rarr[2].readername = "hella";

            rarr[3] = new reader();
            rarr[3].readername = "raddy";

            rarr[4] = new reader();
            rarr[4].readername = "twara";

            publisher p1 = new publisher();
            p1.pubname = "the hindu";
            p1.publish += rarr[0].recievenotify;
            p1.publish += rarr[2].recievenotify;
          

            publisher p2 = new publisher();
            p2.pubname = "toi";
            p2.publish += rarr[1].recievenotify;
            p2.publish += rarr[3].recievenotify;
            p2.publish += rarr[4].recievenotify;
            

            p1.releasecopy();
            p2.releasecopy();

        }
    }
    public delegate void notify(string msg);
    class publisher
    {
        public string pubname;
      
        public event notify publish;
        public void releasecopy()
        {
            Console.WriteLine(pubname + " released a new copy");
            if (publish != null)
            {
                publish(pubname);
            }

        }
    }
    class reader
    {
        public String readername;
        public void recievenotify(string pname)
        {
            Console.WriteLine(readername + " recieved notificatiion");
        }

    }
}
