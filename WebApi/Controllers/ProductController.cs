using Domain.Dtos;
using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController:ControllerBase
{
   
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
                _productService = productService;
        }

        [HttpGet("GetProducts")]
        public List<ProductDto> GetProducts()
        {
                return _productService.GetProducts();
        }

        [HttpGet("GetProductByName")]
        public List<ProductDto> GetProductByName([FromQuery] string name)
        {
                return _productService.GetProductByName(name);
        }

        [HttpGet("GetProductById")]
        public Product GetProductByID([FromQuery] int id)
        {
                return _productService.GetProductById(id);
        }

        [HttpPost("AddProduct")]
        public bool AddProduct(ProductDto product)
        {
                _productService.AddProduct(product);
                return true;
        }

        [HttpPut("UpdateProduct")]
        public bool UpdateProduct(ProductDto product)
        {
                _productService.UpdateProduct(product);
                return true;
        }

        [HttpDelete("DeleteProduct")]
        public void DeleteProduct(int id)
        {
                _productService.DeleteProduct(id);
        }     
}