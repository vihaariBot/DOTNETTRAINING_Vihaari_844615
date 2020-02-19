using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace schoolautomationhandson_18_2.Controllers
{
    public class schoolController : Controller
    {
        // GET: school
        public ActionResult add()
        {
            return View();
        }

        public ActionResult addtodb(int sid,string sname,int scount,int eid,string city)
        {
            automatedexamsEntities1 e = new automatedexamsEntities1();
            school sc = new school();
            bool flag=false;
           foreach(var v in e.exams)
            {
                if(v.eid==eid)
                {
                   flag = true;
                }
            }
           if(flag)
            {
                sc.sid = sid;
                sc.sname = sname;
                sc.count = scount;
                sc.examid = eid;
                sc.city = city;
                e.schools.Add(sc);
                e.SaveChanges();
            }
           
            return View();
        }
    }
}