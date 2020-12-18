using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
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
        [TestMethod]
        public void SetName_SetsNameOfVendor_String()
        {
            string name = "Patty's Cafe";
            string newName = "Jim's Cafe";
            Vendor newVendor = new Vendor(name, "description");
            newVendor.Name = newName;
            string result = newVendor.Name;
            Assert.AreEqual(newName, result);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyListOfVendors_VendorList()
        {
            List<Vendor> vendors = new List<Vendor> { };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(vendors, result);
        }
        [TestMethod]
        public void GetAll_ReturnsFullListOfVendors_VendorList()
        {
            Vendor vendor1 = new Vendor("name", "description");
            List<Vendor> vendors = new List<Vendor> { vendor1 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(vendors, result);
        }
        [TestMethod]
        public void GetId_ReturnsIdOfVendor_Int()
        {
            Vendor vendor = new Vendor("name", "description");
            int testId = 1;
            int result = vendor.Id;
            Assert.AreEqual(testId, result);
        }
        [TestMethod]
        public void Find_ReturnsVendorAtThatId_Vendor()
        {
            Vendor vendor1 = new Vendor("name", "description");
            Vendor vendor2 = new Vendor("name", "description");
            Vendor result = Vendor.Find(1);
            Assert.AreEqual(vendor1, result);
        }
    }
}