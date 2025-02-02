﻿using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDrink();
        decimal AverageProductPrice();
        string MinimumProductPriceName();
        string MaximumProductPriceName();
        decimal AveragePriceByHamburger();
        decimal ProductPriceBySteakBurger();
        decimal TotalPriceByDrinkCategory();
        decimal TotalPriceBySaladCategory();
        List<Product> GetLast9Products();
    }
}
