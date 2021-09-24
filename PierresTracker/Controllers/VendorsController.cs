using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresTracker.Models;
using System;

namespace PierresTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }