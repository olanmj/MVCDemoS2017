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
        private IProductRepository repo;

        public ProductController(IProductRepository repository)
        {
            repo = repository;
        }
        public IActionResult Index()
        {
            return View(repo.GetProductList());
        }

        // GET: /<controller>/
        public IActionResult ShowProduct(int? id)
        {
            Product prod;
            if (id == null)
            {
                prod = new Product
                {
                    ProductID = 101,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Price = 1000M,
                    Category = "Watersports"
                };
            }
            else
            {
                prod = repo.GetProduct((int) id);
            }

            return View(prod);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = repo.GetProduct((int) id);

            if (product == null)
            {
                return NotFound();
            }
            return View("ShowProduct", product);
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
                repo.Add(product);
                return RedirectToAction("Index");

            }
            else
            {
                return View(product);
            }
        }

        public IActionResult EditProduct(int? id)
        {
            if (id == null) return NotFound();

            var product = repo.GetProduct((int)id);

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult EditProduct(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }
            repo.UpdateProduct(id, product);
            return RedirectToAction("Index");
        }
    }
}


