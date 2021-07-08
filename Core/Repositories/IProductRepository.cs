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
    }
}
