using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvchandson14_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SelectListItem[] skills = new SelectListItem[2];
            skills[0] = new SelectListItem() { Text = "c", Value = "0" };
            skills[1] = new SelectListItem() { Text = "java", Value = "2" };
            ViewBag.skills = skills;
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
    }
}