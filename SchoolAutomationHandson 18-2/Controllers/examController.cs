using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace schoolautomationhandson_18_2.Controllers
{
    public class examController : Controller
    {
        // GET: exam
        public ActionResult add()
        {
            return View();
        }
        public ActionResult addtodb(int examid,string ename, int scount,int year)
        {
            automatedexamsEntities1 e = new automatedexamsEntities1();
            exam ex = new exam();
            ex.eid = examid;
            ex.ename = ename;
            ex.subjectcount = scount;
            ex.year = year;
            e.exams.Add(ex);
            e.SaveChanges();
            return View();
            
        }
    }
}