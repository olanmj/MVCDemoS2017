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
        // This needs to be static
        private static ProductRepository repo = new ProductRepository();

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
           // return View(repo.ProductList);
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

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                //repo.Add(product);
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(product);
            }
        }
    }
}

