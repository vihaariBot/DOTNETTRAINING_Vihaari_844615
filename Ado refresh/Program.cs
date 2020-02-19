using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace adoconnection_refresh
{
    class Program
    {
        static void Main(string[] args)
        {
            /* connection model
             *string constr = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=login;Integrated Security=true";
             SqlConnection con = new SqlConnection(constr);
             con.Open();
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText="select * from data";
             cmd.Connection = con;
             var reader=cmd.ExecuteReader();
             while(reader.Read())
             {
                 for(int i=0;i<reader.FieldCount;i++)
                 {
                     Console.WriteLine(reader[i]);
                 }
             }
             reader.Close();
             con.Close();
             */
             /* disconnection model
            string constr = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=login;Integrated Security=true";
            SqlDataAdapter adp = new SqlDataAdapter("select * from data", constr);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            if(ds.Tables.Count>0)
            {
                DataTable dt = ds.Tables[0];
                for(int i=0;i< dt.Rows.Count;i++)
                {
                    for(int j=0;j<dt.Columns.Count;j++)
                    Console.WriteLine(dt.Rows[i][j].ToString());
                }
            }
            */

        }
    }
}
