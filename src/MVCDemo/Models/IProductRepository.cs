using System.Collections.Generic;

namespace MVCDemo.Models
{
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetProductList();

        Product GetProduct(int? id);
    }
}