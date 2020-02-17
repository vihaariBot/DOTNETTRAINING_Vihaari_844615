using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvchandson_mailapplication15_2.Models
{
    public class maildata
    {
        public int mailid { get; set; }
        public int userid { get; set; }
        public string mailfrom { get; set; }
        public string subject { get; set; }
        public DateTime recievedate { get; set; }
        public string messge { get; set; }
    }
}