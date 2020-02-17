using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace adodataobjectsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* normal way of getting data from database using ado
             * string constr = "Data Source=BLT10120\\SQLEXPRESS;Initial Catalog=elhan;Integrated Security=true";
              SqlConnection con = new SqlConnection(constr);
              con.Open();

              SqlCommand cmd = new SqlCommand();
              cmd.Connection = con;
              cmd.CommandText = "select * from employee";
              SqlDataReader reader= cmd.ExecuteReader();
              List<data> dat = new List<data>();
              while(reader.Read())
              {
                  int m = int.Parse(reader[0].ToString());
                  string name = reader[1].ToString();
                  int n= int.Parse(reader[2].ToString());
                  data da = new data(m, name, n);
                  dat.Add(da);

              }
              reader.Close();
              con.Close();
              for(int i=0;i<dat.Count;i++)
              {
                  Console.WriteLine(dat[i].name);
                  Console.WriteLine(dat[i].id);
              }
              */
            /* to get data using entity framework
            //creating object for class defined by designer
          testEntities ctx = new testEntities();
          // to get the data from table
          var depart = ctx.departments;
         foreach(var obj in depart)
          {
              Console.Write(obj.dep_location+' ');
              Console.WriteLine(obj.dep_name);
          }
          */
            /* to get data from database using linq and entity framework
             * to select or filter get data
             * query expression linq
              testEntities ctx = new testEntities();
               var res = from e in ctx.employees where e.emp_id != null select e;
              var res = from e in ctx.employees where e.dep_id == 1 select new { name = e.emp_name, id = e.emp_id };

              foreach(var obj in res)
              {
                  Console.WriteLine(obj.name);
                  Console.WriteLine(obj.id);
              }
              */
            /*  method invocation
                    testEntities ctx = new testEntities();
                    var res = ctx.employees.Where(d => d.dep_id == 1).Select(e=>e.emp_name);
                    foreach (var obj in res)
                    {
                        Console.WriteLine(obj);
                        //Console.WriteLine(obj.id);
                    }
                    */
            testEntities ctx = new testEntities();
           /* order by in query expression
            *var res = from e in ctx.employees
                      orderby e.salary descending
                      select new { name = e.emp_name, id = e.emp_id };
            order by in method invocation
            var res= ctx.employees.OrderByDescending(e=>e.salary).select(e=>e.emp_name); 
            foreach (var obj in res)
            {
                Console.WriteLine(obj.name);
                Console.WriteLine(obj.id);
            }*/
            /*
             * using navigation accessing related data of other table data
            var res= from d in ctx.departments select d;
            foreach(var obj in res)
            {
                Console.WriteLine(obj.dep_name + " " + obj.employees.Count);
                foreach(var e in obj.employees)
                {
                    Console.WriteLine(e.emp_name);
                }
            }
            */
            /*
            var res1 = from d in ctx.employees select d;
            foreach(var obj in res1)
            {
                Console.WriteLine(obj.emp_name + " " + obj.department.dep_name);
            }
            */
        }
}
}
