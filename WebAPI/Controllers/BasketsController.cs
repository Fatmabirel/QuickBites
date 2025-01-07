using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DtoLayer.BasketDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;
        public BasketsController(IBasketService basketService, IMapper mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetBasketByRestaurantTableId(int id)
        {
            return Ok(_basketService.GetBasketByRestaurantTableId(id));
        }

        [HttpGet("BasketListByRestaurantTableWithProductName")]
        public IActionResult BasketListByRestaurantTableWithProductName(int id)
        {
            var value = _mapper.Map<List<ResultBasketWithProductDto>>(_basketService.GetBasketWithProductName(id));
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {            
            using var context = new QuickBitesContext();
            _basketService.Add(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                RestaurantTableId = createBasketDto.RestaurantTableId,
                Count = 1,
                Price = context.Products.Where(x => x.Id == createBasketDto.ProductId).Select(y => y.Price).FirstOrDefault(),
                TotalPrice = createBasketDto.TotalPrice,
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.GetById(id);
            _basketService.Delete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}
