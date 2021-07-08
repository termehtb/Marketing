using MarketingApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MarketingApp.Model.Staff;
using MarketingApp.repo;
using System.Data;
using System.Data.SqlClient;

namespace MarketingApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }
        public int createStaff()
        {
            SalesPerson salesPerson = new SalesPerson
            {
                Name = Request.Query["name"],
                Lastname = Request.Query["lastname"],
                Code =Convert.ToInt32(Request.Query["code"]),
                Commission = Convert.ToInt32(Request.Query["commission"]),
                Phone_number = Request.Query["phone"],
                Mobile= Request.Query["mobile"],
                Address = Request.Query["address"]

            };

            salesPerson.Id = Staff.CreateStaff(salesPerson);

            return salesPerson.Id;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
