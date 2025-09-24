using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarListUsingModel.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Details()
        {
            return View();
        }

        public ActionResult Lists()
        {
            return View();
        }
    }
}