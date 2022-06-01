using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac6_MVC.Controllers
{
    public class ErrorController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HandleError]
        public ActionResult NotFound()
        {
            return View();
        }
    }
}