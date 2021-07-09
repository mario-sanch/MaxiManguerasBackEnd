using Api.Models;
using AutoMapper;
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
        private IMapper _mapper;
        #endregion

        #region Constructors
        public ProductsController(IProductService productService, IMapper mapper)
        {
            this._productService = productService ?? throw new ArgumentNullException(nameof(productService));
            this._mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }
        #endregion

        #region Methods
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts(string category)
        {
            try
            {
                var products = await this._productService.GetProducts();
                var prodsDto = this._mapper.Map<IEnumerable<ProductDto>>(products);
                return Ok(prodsDto);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{productId:int}", Name = "GetProduct")]
        public async Task<ActionResult<ProductDto>> GetProduct(int productId)
        {
            try
            {
                var product = await this._productService.GetProduct(productId);

                if (product == null || product.Id < 1) return NotFound();

                return Ok(this._mapper.Map<ProductDto>(product));
            }
            catch (Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> CreateProduct(ProductForCreationDto product)
        {
            try
            {
                var newProduct = this._mapper.Map<Product>(product);

                newProduct = await this._productService.CreateProduct(newProduct);

                return CreatedAtRoute("GetProduct", new { productId = newProduct.Id }, newProduct);
            }
            catch (Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
        #endregion
    }
}
