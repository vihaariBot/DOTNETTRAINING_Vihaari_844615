using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dalhandson
{
    class Program
    {
        static void Main(string[] args)
        {
            dataaccess ds = new dataaccess();
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int id=ds.login(username, password);
            Console.WriteLine(id);
            List<data> d= ds.access(id);
            for(int i=0;i<d.Count;i++)
            {
                Console.Write(d[i].empid);
                Console.WriteLine(d[i].empname);

            }
        }
    }
}
