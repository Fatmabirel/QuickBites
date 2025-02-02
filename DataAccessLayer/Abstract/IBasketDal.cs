﻿using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<Basket> GetBasketByRestaurantTableId(int id);
        List<Basket> GetBasketWithProductName(int id);
    }
}
