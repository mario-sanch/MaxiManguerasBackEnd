using Core.Repositories;
using Core.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductService : IProductService
    {
        #region Fields
        private IProductRepository _productRepository;
        #endregion

        #region Constructors
        public ProductService(IProductRepository prodRepo)
        {
            this._productRepository = prodRepo ?? throw new ArgumentNullException(nameof(prodRepo));
        }
        #endregion

        #region Public Methods
        public async Task<IEnumerable<Product>> GetProducts()
        {
            try
            {
                return await this._productRepository.GetProducts();
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
                return await this._productRepository.GetProduct(productId);
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
                return  this._productRepository.CreateProduct(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
