﻿using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            //Arrange
            var storage = new Mock<IStorage>();
            var orderService = new OrderService(storage.Object);

            //Act
            var order = new Order();
            orderService.PlaceOrder(order);
            storage.Verify(s => s.Store(order));
        }
    }
}
