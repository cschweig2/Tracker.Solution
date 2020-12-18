using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("title", "description", 25, 12182020);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetTitle_ReturnsTitleOfOrder_String()
        {
            string title = "Patty's Pastry Order";
            Order newOrder = new Order(title, "description", 25, 12182020);
            string result = newOrder.Title;
            Assert.AreEqual(title, result);
        }
        [TestMethod]
        public void SetTitle_SetsTitleOfOrder_String()
        {
            string title = "Patty's Pastry Order";
            Order newOrder = new Order(title, "description", 25, 12182020);
            string newTitle = "Justin's Pastry Order";
            newOrder.Title = newTitle;
            string result = newOrder.Title;
            Assert.AreEqual(newTitle, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyListOfOrders_OrderList()
        {
            List<Order> orders = new List<Order> {};
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(orders, result);
        }
        [TestMethod]
        public void GetAll_ReturnsFullListOfOrders_OrderList()
        {
            Order order1 = new Order("title", "description", 25, 12182020);
            List<Order> orders = new List<Order> { order1 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(orders, result);
        }
        [TestMethod]
        public void GetId_ReturnsIdOfOrder_Int()
        {
            Order newOrder = new Order("title", "description", 25, 12182020);
            int testId = 1;
            int result = newOrder.Id;
            Assert.AreEqual(testId, result);
        }
    }
}