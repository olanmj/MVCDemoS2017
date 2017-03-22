using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers.WebAPI
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository repo)
        {
            _productRepository = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetProductList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return new ObjectResult( _productRepository.GetProduct(id) );
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Product value)
        {
            _productRepository.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _productRepository.UpdateProduct(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Product Delete(int id)
        {
            return _productRepository.DeleteProduct(id);
        }
    }
}
