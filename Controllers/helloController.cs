using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCsampleapp.Controllers
{
    public class helloController : Controller
    {
        // GET: hello
        public ActionResult Index()
        {
            return View();
        }

        public string Home()
        {
            return "this is second router";
        }
      
    }
}