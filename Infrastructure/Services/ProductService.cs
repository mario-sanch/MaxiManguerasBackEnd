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
            return await this._productRepository.GetProducts();
        }
        #endregion
    }
}
