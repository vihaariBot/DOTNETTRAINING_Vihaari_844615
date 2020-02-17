using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvchandson14_2.Controllers
{
    public class submitController : Controller
    {
        // GET: submit
        public ActionResult data(string rname,int skill,DateTime sdate,DateTime edate)
        {
            elhanEntities1 e = new elhanEntities1();
            Table_1 t = new Table_1();
            t.name = rname;
            t.skill = skill;
            t.startdate = sdate;
            t.enddate = edate;
            e.Table_1.Add(t);
            e.SaveChanges();
            
            return View();
        }
    }
}