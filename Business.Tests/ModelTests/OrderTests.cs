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
    [TestMethod]
    public void GetDetails_ReturnsDetails_String()
    {
      string name = "Zonic Cafe";
      string description = "30 Croissants";
      string date = "5/14/2021";
      string price = "0.5 per croissant";
      Order newOrder = new Order(name, description, date, price);
      string result1 = newOrder.Name;
      string result2 = newOrder.Description;
      string result3 = newOrder.Date;
      string result4 = newOrder.Price;
      Assert.AreEqual(name, result1);
      Assert.AreEqual(description, result2);
      Assert.AreEqual(date, result3);
      Assert.AreEqual(price, result4);
      
    }

  }
}