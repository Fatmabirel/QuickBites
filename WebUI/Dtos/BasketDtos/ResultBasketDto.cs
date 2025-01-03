﻿namespace WebUI.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int RestaurantTableId { get; set; }
    }
}
