using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository repo = new ProductRepository();

        //public ProductController()
        //{
          
        //}

        public IActionResult Index()
        {
            return View(repo.ProductList);
        }

        // GET: /<controller>/
        public IActionResult ShowProduct()
        {
            Product p = new Product
            {
                ProductID = 101,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 1000M,
                Category = "Watersports"
            };

            return View(p);
        }
    }
}

