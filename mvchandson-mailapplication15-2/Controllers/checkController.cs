using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvchandson_mailapplication15_2.Models;

namespace mvchandson_mailapplication15_2.Controllers
{
    public class checkController : Controller
    {
        // GET: check
        public ActionResult signin(string username,string password)
        {
            loginEntities1 e = new loginEntities1();
            var idd = from t in e.logins where (t.username == username && t.password == password) select t.id;
            var id = idd.FirstOrDefault();
            var data = from t in e.maildetails where (t.userid == id) select t;
            List<mvchandson_mailapplication15_2.Models.maildata> maillist = new List<mvchandson_mailapplication15_2.Models.maildata>();
            foreach (var t in data)
            {
                mvchandson_mailapplication15_2.Models.maildata mail = new mvchandson_mailapplication15_2.Models.maildata();
                mail.mailid = t.mailid;
                mail.userid = t.userid;
                mail.mailfrom =t.mailfrom;
                mail.subject = t.subject;
                mail.recievedate = t.recievedate;
                mail.messge = t.message;
                maillist.Add(mail);
            }

            return View(maillist);
        }
        public ActionResult viewmessage(int mid)
        {
            loginEntities1 e = new loginEntities1();
            var data = from t in e.maildetails where (t.userid == mid) select t;
            var mdata = data.FirstOrDefault();
            mvchandson_mailapplication15_2.Models.maildata mail = new mvchandson_mailapplication15_2.Models.maildata();
            mail.mailid = mdata.mailid;
            mail.userid = mdata.userid;
            mail.mailfrom = mdata.mailfrom;
            mail.subject = mdata.subject;
            mail.recievedate = mdata.recievedate;
            mail.messge = mdata.message;
            return View(mail);
        }
    }
}