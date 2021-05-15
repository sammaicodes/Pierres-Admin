using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Models;
using System.Collections.Generic;
using System;

namespace Business.Tests
{
  [TestClass]
  public class VendorTests:IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test");
      string result = newVendor.VendorName;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name, "test");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Doppio Cafe";
      string name02 = "North Shore Cafe";
      Vendor newVendor1 = new Vendor(name01, "test");
      Vendor newVendor2 = new Vendor(name02, "test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Doppio Cafe";
      string name02 = "North Shore Cafe";
      Vendor newVendor1 = new Vendor(name01, "test");
      Vendor newVendor2 = new Vendor(name02, "test");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
        [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "Deliver by 5am";
      Order newOrder = new Order("test", description, "test", "test");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Doppio Cafe";
      Vendor newVendor = new Vendor(name, "test");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    } 
  }
}