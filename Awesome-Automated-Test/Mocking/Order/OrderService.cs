﻿namespace Awesome_Automated_Test.Mocking.Order
{
    public class OrderService : IOrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }

        public int PlaceOrder(Order order)
        {
            var orderId = _storage.Store(order);

            // Some other work

            return orderId;
        }
    }
}