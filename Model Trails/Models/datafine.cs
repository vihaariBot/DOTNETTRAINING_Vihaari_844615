using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modeltrails.Models
{
    public class datafine
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string jname { get; set; }
        public string location { get; set; }
        public List<string> tasks = new List<string>();
        public List<SelectListItem> locs = new List<SelectListItem>();
    }
}