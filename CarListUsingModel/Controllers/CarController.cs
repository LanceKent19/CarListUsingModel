using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarListUsingModel.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult CarPage()
        {
            return View();
        }
    }
}