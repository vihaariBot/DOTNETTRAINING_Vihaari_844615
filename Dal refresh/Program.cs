using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal_refresh
{
    class Program
    {
        static void Main(string[] args)
        {
            string uname = Console.ReadLine();
            string pass = Console.ReadLine();
            dal obj = new dal();
            int id = obj.loginvalid(uname,pass);
            Console.WriteLine(id);
            data d = obj.retrieve(id);
            Console.WriteLine(d.name);
            Console.WriteLine(d.mid);
        }
    }
}
