using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dal
    {
        public int login(string username, string password)
        {
            loginEntities ctx = new loginEntities();
            /*var rec = from e in obj.logins
                      select e;
            var id = from e in rec where e.username == username && e.password == password select new { i = e.id};
            Console.WriteLine(id);
            int i = int.Parse(id.ToString());*/

            var obj = from i in ctx.logins
                      where i.username == username && i.password == password
                      select i;
            var elm = obj.FirstOrDefault();
            if (elm != null)
            {
                return elm.id;
            }
            else
                return -1;

        }
        public List<Det> getsubordinates(int id)
        {
            List<Det> dd = new List<Det>();
            loginEntities obj = new loginEntities();

            var rec = from e in obj.data
                      where e.id == id
                      select e;

            foreach (var e in rec)
            {
                int i = int.Parse(e.id.ToString());
                string name = e.name.ToString();
                Det d = new Det(i, name);
                dd.Add(d);
            }
            return dd;
        }
    }
   public class Det
    {
        public int ii;
        public string name;
        public Det(int id, string nam)
        {
            ii = id;
            name = nam;
        }
    }
}
