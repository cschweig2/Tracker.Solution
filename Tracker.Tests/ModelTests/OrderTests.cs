using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class OrderTests // : IDisposable
    {
        // public void Dispose()
        // {
        // Order.ClearAll();
        // }
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
            string otherNewTitle = "Test Title";
            newOrder.Title = newTitle;
            string result = newOrder.Title;
            Assert.AreEqual(newTitle, result);
        }


    }
}