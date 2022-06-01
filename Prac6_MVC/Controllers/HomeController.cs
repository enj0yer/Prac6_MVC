using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prac6_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Error()
        {
            Response.StatusCode = 404;
            return View();
        }

        [HttpGet]
        public ActionResult Page1()
        {
            return View("Page1");
        }

        [HttpGet]
        public ActionResult Page2()
        {
            return View();
        }
    }
}