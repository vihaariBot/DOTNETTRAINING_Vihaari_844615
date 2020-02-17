using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace csvfile_handson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            List<product> data = new List<product>();
            StreamReader sr = new StreamReader("csv.txt");
            do
            {
                 str = sr.ReadLine();
                if (str != null)
                {
                    string[] obj = str.Split(',');
                    product p = new product(int.Parse(obj[0]), obj[1], Double.Parse(obj[2]));
                    data.Add(p);
                }
            } while (str != null);
            sr.Close();
            data.Sort(new pricecomparer());
            for(int i=0;i<data.Count;i++)
            {
                data[i].price *= 1.1; 
            }
            StreamWriter sw = new StreamWriter("csv.txt");
            for(int i=0;i<data.Count;i++)
            {
                sw.WriteLine(string.Format("{0},{1},{2}",data[i].id,data[i].name,data[i].price));
            }
            sw.Close();
        }
    }
    public class product
    {
        public int id;
        public string name;
        public double price;

        public product(int i,string n, double p)
        {
            id = i;
            name = n;
            price = p;
        }
    }
    public class pricecomparer : IComparer<product>
    {
        public int Compare(product x, product y)
        {
           if(x.price<y.price)
            {
                return 1;
            }
           else if (x.price > y.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}