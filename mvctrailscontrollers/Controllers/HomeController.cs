using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctrailscontrollers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult uber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult uber(userdata data)
        {
            string unam = data.name;
            ViewBag.name = unam;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult process(string data)
        {
            string unam = data;
            ViewBag.uname = unam;
            return View();
        }
    }
}