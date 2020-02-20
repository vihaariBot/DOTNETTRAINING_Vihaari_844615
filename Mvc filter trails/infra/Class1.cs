using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_filter_trails.infra
{
    public class myappexceptionAttribute :FilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filtercontext)
        {
            if(filtercontext.Exception is DivideByZeroException)
            {
                filtercontext.Result = new RedirectResult("~/Content/error.html");
                filtercontext.ExceptionHandled = true;
            }
        }
    }
}