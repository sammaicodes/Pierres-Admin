using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System.Collections.Generic;
using System;

namespace Business.Test
{
  [TestClass]
  public class OrderTests:IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void SetUpdatedName_SetUpdate_String()
    {
      string name = "Country Cafe";
      Order newOrder = new Order(name, "test", "test", "test");
      string updatedName = "Old Fashioned Cafe";
      newOrder.Name = updatedName;
      string result = newOrder.Name;
      Assert.AreEqual(updatedName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string name01 = "Doppio Cafe";
      string name02 = "Bubbas Cafe";
      Order newOrder1 = new Order(name01, "test", "test", "test");
      Order newOrder2 = new Order(name02, "test", "test", "test");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string name = "Doppio Cafe";
      Order newOrder = new Order(name, "test", "test", "test");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
        [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name01 = "Dirty Finger Cafe";
      string name02 = "Uplifted Cafe";
      Order newOrder1 = new Order(name01, "test", "test", "test");
      Order newOrder2 = new Order(name02, "test", "test", "test");
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder2, result);
    }
  }
}