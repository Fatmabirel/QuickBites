﻿using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDrink();
        decimal AverageProductPrice();
        string MinimumProductPriceName();
        string MaximumProductPriceName();
        decimal AveragePriceByHamburger();
    }
}
