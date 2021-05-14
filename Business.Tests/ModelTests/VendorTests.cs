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
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
  }
}