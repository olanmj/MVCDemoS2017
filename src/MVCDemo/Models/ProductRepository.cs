using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class ProductRepository
    {
        public List<Product> ProductList { get; set; }
       

        public ProductRepository()
        {
            ProductList = new List<Product>();

            Product p = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 1000M,
                Category = "Watersports"
            };

            ProductList.Add(p);

            p = new Product
            {
                ProductID = 101,
                Name = "Widget",
                Description = "A useless item",
                Price = 0.99M,
                Category = "Junk"
            };

            ProductList.Add(p);

            p = new Product
            {
                ProductID = 102,
                Name = "Row boat",
                Description = "A boat for one or more people",
                Price = 1000M,
                Category = "Watersports"
            };

            ProductList.Add(p);
        }
    }


}
