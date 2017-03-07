﻿using System.Collections.Generic;

namespace MVCDemo.Models
{
    public interface IProductRepository
    { 
        void Add(Product product);
        Product GetProduct(int id);
        List<Product> GetProductList();
        Product UpdateProduct(Product product);
    }
}