using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class ItemTests : IDisposable
    {
        public void Dispose()
        {
        Item.ClearAll();
        }
    }
}