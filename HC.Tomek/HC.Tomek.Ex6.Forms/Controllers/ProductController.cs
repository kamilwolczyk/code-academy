using HC.Tomek.Ex6.Forms.Data.Abstract.Models;
using HC.Tomek.Ex6.Forms.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex6.Forms.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ComputerRepository sql = new ComputerRepository();
            
            return Json(sql.GetComputers(), JsonRequestBehavior.AllowGet);
        }
    }
}