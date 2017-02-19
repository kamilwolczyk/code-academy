using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using HC.Radek.Ex5.Routing.Data.Abstract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Radek.Ex5.Routing.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Computers()
        {
            ProductsService productsService = new ProductsService();
            IList<Computer> computers = productsService.getComputers();
            IList<Tablet> tablets = productsService.getTablets();
            return Json(new
            {
                Computers = computers
                ,
                Tablets = tablets
            }, JsonRequestBehavior.AllowGet);
        }
    }
}