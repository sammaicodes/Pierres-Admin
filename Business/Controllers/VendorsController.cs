using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Business.Models;

namespace Business.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorAddress)
    {
      Vendor newVendor = new Vendor(vendorName, vendorAddress);
      return RedirectToAction("Index");
    }
  }
}