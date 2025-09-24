using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListUsingModel.Models
{
    public class Car
    {
        public int carID {  get; set; }
        public string carBrand { get; set; }
        public string carDescription { get; set; }
        public string carModel { get; set; }
        public int carPrice { get; set; }
    }
}