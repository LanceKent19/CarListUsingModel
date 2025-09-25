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

        public ActionResult Lists(Car c)
        {
            List<Car> carList = new List<Car>() { 
            new Car() { carID = 1, carBrand = "Toyota", carModel = "Corolla", carDescription = "A compact sedan with reliable fuel efficiency.", carPrice = 850000},
        new Car() { carID = 2, carBrand = "Honda", carModel = "Civic", carDescription = "Sporty Sedan known for its modern design.", carPrice = 1200000 },
        new Car() { carID = 3, carBrand = "Ford", carModel = "Mustang", carDescription = "Iconic sports car with powerful engine options.", carPrice = 2500000 },
        new Car() { carID = 4, carBrand = "Nissan", carModel = "Altima", carDescription = "Mid-sized sedan with sleek comfortabe ride.", carPrice = 1400000 },
        new Car() { carID = 5, carBrand = "BMW", carModel = "X5", carDescription = "Luxury SUV with cutting edge technology.", carPrice = 3000000 },
        new Car() { carID = 6, carBrand = "Chevrolet", carModel = "Silverado", carDescription = "Full-size pickup truck with a robust build.", carPrice = 1800000 },
        new Car() { carID = 7, carBrand = "Mercedes", carModel = "Benz E-Class", carDescription = "Elegant sedan with premium features and style.", carPrice = 2800000 },
        new Car() { carID =8, carBrand = "Audi", carModel = "A4", carDescription = "Sedan with a blend of performance and luxury.", carPrice = 2200000 },
        new Car() { carID =9, carBrand = "Hyundai", carModel = "Tucson", carDescription = "Compact SUV offering excellent value for money.", carPrice = 1150000 },
        new Car() { carID =10, carBrand = "Kia", carModel = "Sorento", carDescription = "Versatile SUV with a spacious interior.", carPrice = 1450000 },
        // Your new car added from the form:
       };
            return View(carList);
        }
    }
}