using Core.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            products.Add(new Product { Id = 2, Name = "Product 2", Description = "Description product 2", Price = 12.19, ImageUrl = string.Empty });
        }
        #endregion

        #region Public Methods
        public async Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                return await Task.FromResult(this._products);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetProduct(int productId)
        {
            try
            {
                var product = await Task.FromResult(this._products.FirstOrDefault(p => p.Id == productId));

                return product ?? new Product();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Product> CreateProduct(Product product)
        {
            try
            {
                // add checks and tests ...

                product.Id = this._products.Count() + 1;
                this._products.Add(product);

                return Task.FromResult(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task UpdateProduct(Product product)
        {
            // the reference to the object was already modified so no chenge need to be done here!

            return Task.FromResult("");
        }

        public Task<Product> DeleteProduct(Product product)
        {
            try
            {
                var prodToDelete = this._products.FirstOrDefault(p => p.Id == product.Id);

                if (prodToDelete != null) this._products.Remove(prodToDelete);

                return Task.FromResult(prodToDelete);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
