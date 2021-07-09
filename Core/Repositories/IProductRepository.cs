using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int productId);
        Task<Product> CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task<Product> DeleteProduct(Product product);
    }
}
