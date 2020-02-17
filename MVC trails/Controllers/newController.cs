using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvctrails.Controllers
{
    public class newController : Controller
    {
        // GET: new
        public ActionResult signin()
        {
            return View();
        }
    }
}