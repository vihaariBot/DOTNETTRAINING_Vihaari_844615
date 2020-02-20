using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_filter_trails.infra;

namespace MVC_filter_trails.Controllers
{
    public class calcController : Controller
    {
        // GET: calc
       // [myappexception]
        public ActionResult divide()
        {
            int n = 10, k = 0;
            int rem = n / k;
            ViewBag.result = rem;
            return View();
        }
    }
}