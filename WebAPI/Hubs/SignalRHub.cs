﻿using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.SignalR;

namespace WebAPI.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IRestaurantTableService _restaurantTableService;
        public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IRestaurantTableService restaurantTableService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _restaurantTableService = restaurantTableService;
        }

        public async Task SendStatistic()
        {
            var categoryCount = _categoryService.CategoryCount();
            await Clients.All.SendAsync("ReceiveCategoryCount", categoryCount);

            var activeCategoryCount = _categoryService.ActiveCategoryCount();
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", activeCategoryCount);

            var passiveCategoryCount = _categoryService.PassiveCategoryCount();
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", passiveCategoryCount);

            var productCount = _productService.ProductCount();
            await Clients.All.SendAsync("ReceiveProductCount", productCount);

            var productCountByHamburger = _productService.ProductCountByCategoryNameHamburger();
            await Clients.All.SendAsync("ReceiveProductCountByHamburger", productCountByHamburger);

            var productCountByDrink = _productService.ProductCountByCategoryNameDrink();
            await Clients.All.SendAsync("ReceiveProductCountByDrink", productCountByDrink);

            var averageProductPrice = _productService.AverageProductPrice();
            await Clients.All.SendAsync("ReceiveAverageProductPrice", averageProductPrice.ToString("0.00"));

            var maximumProductPriceName = _productService.MaximumProductPriceName();
            await Clients.All.SendAsync("ReceiveMaximumProductPriceName", maximumProductPriceName);

            var minimumProductPriceName = _productService.MinimumProductPriceName();
            await Clients.All.SendAsync("ReceiveMinimumProductPriceName", minimumProductPriceName);

            var averagePriceByHamburger = _productService.AveragePriceByHamburger();
            await Clients.All.SendAsync("ReceiveAveragePriceByHamburger", averagePriceByHamburger.ToString("0.00") + "₺");

            var orderCount = _orderService.TotalOrderCount();
            await Clients.All.SendAsync("ReceiveOrderCount", orderCount);

            var activeOrderCount = _orderService.ActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var lastOrderPrice = _orderService.LastOrderPrice();
            await Clients.All.SendAsync("ReceiveLastOrderPrice", lastOrderPrice.ToString("0.00") + "₺");

            var moneyCaseAmount = _moneyCaseService.TotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveMoneyCaseAmount", moneyCaseAmount.ToString("0.00") + "₺");

            var todayTotalPrice = _orderService.TodayTotalPrice();
            await Clients.All.SendAsync("ReceiveTodayTotalPrice", todayTotalPrice.ToString("0.00") + "₺");

            var restaurantTableCount = _restaurantTableService.TotalRestaurantTableCount();
            await Clients.All.SendAsync("ReceiveRestaurantTableCount", restaurantTableCount);

        }

        public async Task SendProgress()
        {
            var moneyCaseAmount = _moneyCaseService.TotalMoneyCaseAmount();
            await Clients.All.SendAsync("ReceiveMoneyCaseAmount", moneyCaseAmount.ToString("0.00") + "₺");

            var activeOrderCount = _orderService.ActiveOrderCount();
            await Clients.All.SendAsync("ReceiveActiveOrderCount", activeOrderCount);

            var restaurantTableCount = _restaurantTableService.TotalRestaurantTableCount();
            await Clients.All.SendAsync("ReceiveRestaurantTableCount", restaurantTableCount);
        }
    }
}