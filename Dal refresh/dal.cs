using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace dal_refresh
{
    class dal
    {
        public int loginvalid(string uname,string pass)
        {
            string constr = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=login;Integrated Security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select id from login where username='"+uname+"' and password='"+pass+"'";
            cmd.Connection = con;
            int val=int.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            return val;
        
           

        }
        public data retrieve(int id)
        {
            data d = new data();
            string constr = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=login;Integrated Security=true";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select name,mid from data where id=" + id;
            cmd.Connection=con;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                d.name = reader[0].ToString();
                d.mid = int.Parse(reader[1].ToString());
            }
            return d;
        }
       
    }
    public class data
    {
        public string name;
        public int mid;
    }
}
