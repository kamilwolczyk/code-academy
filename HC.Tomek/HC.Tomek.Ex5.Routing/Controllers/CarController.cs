using HC.Tomek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;

namespace HC.Tomek.Ex5.Routing.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        //[HttpPost]
        public ActionResult Index()
        {
            CarList cars = new CarList();
            cars.Cars.Add(new Car { Marka = "Opel", Model = "Astra", RokProducji = 2010 });
            cars.Cars.Add(new Car { Marka = "BMW", Model = "5", RokProducji = 2014 });
            cars.Cars.Add(new Car { Marka = "Renault", Model = "Megane", RokProducji = 2009 });
            return View(cars);
        }
        
    }
}