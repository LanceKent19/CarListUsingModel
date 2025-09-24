using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListUsingModel.Models
{
    public class Car
    {
        public int carID {  get; set; }
        public String carBrand { get; set; }
        public String carDescription { get; set; }
        public String carModel { get; set; }
        public double carPrice { get; set; }
    }
}