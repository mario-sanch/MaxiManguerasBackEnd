﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int productId);
        Task<Product> CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task<Product> DeleteProduct(Product product);
    }
}
