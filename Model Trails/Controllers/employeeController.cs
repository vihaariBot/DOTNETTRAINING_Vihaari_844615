using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modeltrails.Models;

namespace modeltrails.Controllers
{
    public class employeeController : Controller
    {
        // GET: employee
        public ActionResult addnew()
        {
            datafine d = new datafine();
            d.locs.Add(new SelectListItem() { Text = "chennai", Value = "1" });
            d.locs.Add(new SelectListItem() { Text = "hyderabad", Value = "2" });
            d.locs.Add(new SelectListItem() { Text = "bangalore", Value = "3" });
            return View(d);
        }
        [HttpPost]
        public ActionResult addnew(datafine model)
        {
            return View(model);
        }
        public ActionResult editemp()
        {
            datafine d = new datafine();
            d.fname = "raja";
            d.lname = "noob";
            d.location = "mirzapur";
            return View(d);
        }
    }
}