using HC.Radek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //[HttpPost]
        public ActionResult Index()
        {
            CarList c = new CarList();
            c.cars.Add(new Car {Marka = "Polonez", Model = "Caro", Rok = "1990" });
            c.cars.Add(new Car { Marka = "Mercedes", Model = "C", Rok = "2010" });
            c.cars.Add(new Car { Marka = "Audi", Model = "A4", Rok = "2016" });

            //return Json(c,JsonRequestBehavior.AllowGet);
            //return Json(c);
            return View(c);
        }
    }
}