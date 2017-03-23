using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    [Route("api/[controller]")]
    public class ProductAPIController : Controller
    {
        private readonly IProductRepository _productRepo;

        public ProductAPIController(IProductRepository repo)
        {
            _productRepo = repo;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepo.GetProductList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productRepo.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return new ObjectResult(product);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            _productRepo.Add(value);
            return  Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product updatedProduct)
        {
            _productRepo.UpdateProduct(id, updatedProduct);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productRepo.DeleteProduct(id);
        }
    }
}
