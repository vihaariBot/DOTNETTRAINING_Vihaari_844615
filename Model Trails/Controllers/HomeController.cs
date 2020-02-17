using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modeltrails.Models;

namespace modeltrails.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            datafine d = new datafine();
            d.fname = "jobu";
            d.lname="gobu";
            d.tasks.Add("hello");
            d.tasks.Add("world");
            return View(d);
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
    }
}