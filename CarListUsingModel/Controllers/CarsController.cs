using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarListUsingModel.Models;

namespace CarListUsingModel.Controllers

{
    public class CarsController : Controller
    {        // GET: Cars
        [HttpGet]
        public ActionResult Details()
        {
           
            ViewBag.carID = "Value";
            ViewBag.carBrand = "Value";
            ViewBag.carDescription = "Value";
            ViewBag.carModel = "Value";
            ViewBag.carPrice =  "Value";
            return View();
        }


        [HttpPost]
        public ActionResult Details(Car c )
        {

            ViewBag.carID = c.carID;
            ViewBag.carBrand = c.carBrand;
            ViewBag.carDescription = c.carDescription;
            ViewBag.carModel = c.carModel;
            ViewBag.carPrice = c.carPrice;
            return View();
        }

        public ActionResult Lists()
        {
            return View();
        }
    }
}