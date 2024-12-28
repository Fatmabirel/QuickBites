using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.ProductDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.GetAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var value = _mapper.Map<List<ResultProductWithCategory>>(_productService.GetProductsWithCategories());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            var value = _mapper.Map<Product>(createProductDto);
            _productService.Add(value);
            return Ok("Ürün Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.GetById(id);
            _productService.Delete(value);
            return Ok("Ürün Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.GetById(id);
            return Ok(_mapper.Map<GetProductDto>(value));
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            var value = _mapper.Map<Product>(updateProductDto);
            _productService.Update(value);
            return Ok("Ürün Bilgisi Güncellendi");
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.ProductCount());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.ProductCountByCategoryNameDrink());
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.ProductCountByCategoryNameHamburger());
        }

        [HttpGet("AverageProductPrice")]
        public IActionResult AverageProductPrice()
        {
            return Ok(_productService.AverageProductPrice());
        }

        [HttpGet("MinimumProductPriceName")]
        public IActionResult MinimumProductPriceName()
        {
            return Ok(_productService.MinimumProductPriceName());
        }

        [HttpGet("MaximumProductPriceName")]
        public IActionResult MaximumProductPriceName()
        {
            return Ok(_productService.MaximumProductPriceName());
        }

        [HttpGet("AveragePriceByHamburger")]
        public IActionResult AveragePriceByHamburger()
        {
            return Ok(_productService.AveragePriceByHamburger());
        }
    }
}
