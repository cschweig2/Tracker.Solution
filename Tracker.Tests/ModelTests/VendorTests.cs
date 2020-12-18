using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("name", "description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsNameOfVendor_String()
        {
            string name = "Patty's Cafe";
            Vendor newVendor = new Vendor(name, "description");
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
    }
}