﻿namespace Ambev.DeveloperEvaluation.Application.Orders.CreateOrder
{
    public class CreateOrderItemCommand
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
    }
}