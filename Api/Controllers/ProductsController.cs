using Core.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        #region Fields
        private IProductService _productService;
        #endregion

        #region Constructors
        public ProductsController(IProductService productService)
        {
            this._productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }
        #endregion

        #region Methods
        [HttpGet()]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await this._productService.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{productId:int}")]
        public async Task<IActionResult> GetProduct(int productId)
        {
            try
            {
                var product = await this._productService.GetProduct(productId);

                if (product == null || product.Id < 1) return NotFound();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
        #endregion
    }
}
