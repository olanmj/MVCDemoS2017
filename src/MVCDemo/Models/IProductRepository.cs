using System.Collections.Generic;

namespace MVCDemo.Models
{
    public interface IProductRepository
    { 
        void Add(Product product);
        Product GetProduct(int id);
        List<Product> GetProductList();
        void UpdateProduct(int id, Product product);
        Product DeleteProduct(int id);
    }
}