using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name, int number)
        {
            ViewData["UserName"] = name;
            ViewData["UserNum"] = number;

            CookieOptions expires = new CookieOptions
            {
                Expires = DateTime.Now.AddYears(1)
            };

         //   Response.Cookies.Append("ZipCode", "08205", expires);

            Response.Cookies.Append("lastvisit", DateTime.Now.ToString());

            ViewData["Visited"] = Request.Cookies["lastvisit"];
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
