using Core.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
