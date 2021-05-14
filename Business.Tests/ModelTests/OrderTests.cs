using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System.Collections.Generic;
using System;

namespace Business.Test
{
  [TestClass]
  public class OrderTests //:IDisposable
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}