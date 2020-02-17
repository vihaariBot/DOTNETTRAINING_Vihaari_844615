using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace dalhandson
{
    class dataaccess
    {
        public int login(string user, string pass)
        {
            string str = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog= login;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id from login where username='"+user+"' and password='"+pass+"'";
            cmd.Connection = con;
            int id = int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return id;
        }
        public List<data> access (int id)
        {
            string str = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog= login;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id,name from data where mid='" + id +"'";
            cmd.Connection = con;
            SqlDataReader rd = cmd.ExecuteReader();
            List<data> d = new List<data>();
            while(rd.Read())
            {
                int i = int.Parse(rd[0].ToString());
                string name = rd[1].ToString();
                data dd = new data(i, name);
                d.Add(dd);
            }
            return d;

        }
       
    }

    public class data
    {
        public int empid;
        public string empname;
        public data(int emp, string name)
        {
            empid = emp;
            empname = name;
        }
    }
}
