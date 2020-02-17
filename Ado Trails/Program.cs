using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ado1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com = new SqlCommand();
            com.CommandText = "select * from employees";
            com.Connection = con;
            //int n = int.Parse(com.ExecuteScalar().ToString());
            //Console.WriteLine(n);

            SqlDataReader reader = com.ExecuteReader();
            while(reader.Read())
            {
                int id = int.Parse(reader[0].ToString());
                string name = reader[1].ToString();
                string mn = reader[2].ToString();
                int mid = int.Parse(reader[3].ToString());
                string date = reader[4].ToString();
                Console.WriteLine(id);
                Console.WriteLine(name+' '+mn);
            }
            con.Close();

        }
    }
}
