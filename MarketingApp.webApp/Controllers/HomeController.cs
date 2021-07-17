using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MarketingApp.Model.Staff;
using MarketingApp.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarketingApp.webApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Salespersons()
        {
            ViewBag.Salespersons = Staff.GetStaff();

            return View();
        }


        public int createSalesperson()
        {
            int id;
            SalesPerson salesPerson = new SalesPerson
            {
                Name = Request.Params["name"],
                Lastname = Request.Params["lastname"],
                Code = Convert.ToInt32(Request.Params["code"]),
                Commission = Convert.ToInt32(Request.Params["commission"]),
                Phone_number = Request.Params["phone"],
                Mobile = Request.Params["mobile"],
                Address = Request.Params["address"]

                };
                salesPerson.Id = Staff.CreateStaff(salesPerson);
                id = salesPerson.Id;
            return id;
        }

        public ActionResult StaffList()
        {
            ViewBag.StaffList = Staff.GetStaff();

            return View();
        }

        public ActionResult GetStaff([DataSourceRequest] DataSourceRequest request)
        {
            return Json(Staff.GetStaff().ToDataSourceResult(request));
        }

    }
}