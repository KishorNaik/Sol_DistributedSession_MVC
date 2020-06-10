using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sol_Demo.Controllers
{
    public class SessionDemoController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("MySession", "Hello Asp.net Core MVC");

            return View();
        }

        public IActionResult GetSessionValue()
        {
            ViewBag.SessionValue = HttpContext.Session.GetString("MySession");

            HttpContext.Session.Remove("MySession");

            return View("Index");
        }
    }
}