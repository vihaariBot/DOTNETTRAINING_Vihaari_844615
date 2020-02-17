using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcloginhandson13_2.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult signin(string input1,string input2)
        {
            newcompanyEntities2 obj = new newcompanyEntities2();
            var userid = from i in obj.logininfoes where (i.usname == input1) && (i.pwd == input2) select i.usid;
            var uid = userid.FirstOrDefault();
            if (uid != 0)
            {
                var data = from i in obj.userdetails where (i.usid == uid) select i;
                var nam = data.FirstOrDefault();
                ViewBag.name = nam.fname;
                ViewBag.age = nam.age;
                ViewBag.city = nam.city;
                ViewBag.rto = nam.rto;
                return View();
            }
            else
            {
                return View("failedlogin");
            }
        }
    }
}