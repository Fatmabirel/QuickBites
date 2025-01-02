using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.RestaurantTableDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantTablesController : ControllerBase
    {
        private readonly IRestaurantTableService _restaurantTableService;
        private readonly IMapper _mapper;
        public RestaurantTablesController(IRestaurantTableService restaurantTableService, IMapper mapper)
        {
            _restaurantTableService = restaurantTableService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RestaurantTableList()
        {
            var values = _restaurantTableService.GetAll();
            return Ok(_mapper.Map<List<ResultRestaurantTableDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateRestaurantTable(CreateRestaurantTableDto createRestaurantTableDto)
        {
            var value = _mapper.Map<RestaurantTable>(createRestaurantTableDto);
            _restaurantTableService.Add(value);
            return Ok("Masa Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRestaurantTable(int id)
        {
            var value = _restaurantTableService.GetById(id);
            _restaurantTableService.Delete(value);
            return Ok("Masa Silindi");
        }
        [HttpPut]
        public IActionResult UpdateRestaurantTable(UpdateRestaurantTableDto updateRestaurantTableDto)
        {
            var value = _mapper.Map<RestaurantTable>(updateRestaurantTableDto);
            _restaurantTableService.Update(value);
            return Ok("Masa Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetRestaurantTable(int id)
        {
            var value = _restaurantTableService.GetById(id);
            return Ok(_mapper.Map<GetRestaurantTableDto>(value));
        }

        [HttpGet("TotalRestaurantTableCount")]
        public IActionResult TotalRestaurantTableCount()
        {
            return Ok(_restaurantTableService.TotalRestaurantTableCount());
        }
    }
}
