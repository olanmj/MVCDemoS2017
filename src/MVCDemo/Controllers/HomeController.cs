﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string name, int number)
        {
            ViewData["UserName"] = name;
            ViewData["UserNum"] = number;
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
