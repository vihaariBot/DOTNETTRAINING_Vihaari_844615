using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
 using System.Data.SqlClient;
using System.Data;

namespace adod1handson
{
    class Program
    {
        static void Main(string[] args)
        {
          List<data> obj = new List<data>();
            string str = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=data;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "    select * from student s inner join enrollment e on s.stid= e.stid inner join course c on e.cid= c.cid ";
            com.Connection = con;
           
            SqlDataReader reader = com.Execu teReader();
           
            while (reader.Read())
            {
                int stid = int.Parse(reader[0].ToString());
                string sname = reader[1].ToString();
                int age = int.Parse(reader[2].ToString());
                int cid= int.Parse(reader[4].ToString());
                string cname= reader[7].ToString();
                int duration = int.Parse(reader[8].ToString());
                data db = new data(stid,sname,age,cid,cname,duration);
                obj.Add(db);
            }
            reader.Close();
            for (int i=0;i<obj.Count;i++)
            {
                Console.WriteLine(obj[i].stid);
                Console.WriteLine(obj[i].sname);
            }
            con.Close();
            Console.WriteLine("sorting based on student name");
            obj.Sort(new snamecomparer());
            for (int i = 0; i < obj.Count; i++)
            {
               Console.WriteLine(obj[i].stid);
               Console.WriteLine(obj[i].sname);
            }

            Console.WriteLine("sorting based on course name");
            obj.Sort(new cnamecomparer());
            for (int i = 0; i < obj.Count; i++)
            {
                Console.WriteLine(obj[i].stid);
                Console.WriteLine(obj[i].sname);
            }
            
            
        }
        public class data
        {
           public int stid;
           public string sname;
           public  int age;
            public int cid;
            public string cname;
            public int duration;

            public data(int st,string sna, int ag, int ci,string cna, int dur)
            {
                stid = st;
                sname = sna;
                age = ag;
                cid = ci;
                cname = cna;
                duration = dur;
            }
        }
        public class snamecomparer : IComparer<data>
        {
            public int Compare(data x, data y)
            { 
               return  string.Compare(x.sname, y.sname);
            }
        }

        public class cnamecomparer : IComparer<data>
        {
            public int Compare(data x, data y)
            {
                return string.Compare(x.cname, y.cname);
            }
        }
    }
}
