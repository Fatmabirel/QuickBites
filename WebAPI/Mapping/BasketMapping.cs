using AutoMapper;
using DtoLayer.BasketDto;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, ResultBasketWithProductDto>().ReverseMap();
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
        }
    }
}
