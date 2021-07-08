using Core.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MockProductRepository : IProductRepository
    {
        #region Fields
        private IList<Product> _products;
        #endregion

        #region Constructors
        public MockProductRepository()
        {
            this._products = new List<Product>();
            this.FillProducts(this._products);
        }
        #endregion

        #region Private Methods
        private void FillProducts(IList<Product> products)
        {
            products.Add(new Product { Id = 1, Name = "Product 1", Description = "Description product 1", Price = 10.15, ImageUrl = string.Empty });
            products.Add(new Product { Id = 1, Name = "Product 2", Description = "Description product 2", Price = 12.19, ImageUrl = string.Empty });
        }
        #endregion

        #region Public Methods
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await Task.FromResult(this._products);
        }
        #endregion
    }
}
