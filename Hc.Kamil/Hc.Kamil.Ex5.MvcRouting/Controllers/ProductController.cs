using System.Web.Mvc;
using Hc.Kamil.Ex5.MvcRouting.Configuration;
using Hc.Kamil.Ex5.MvcRouting.Services;

namespace Hc.Kamil.Ex5.MvcRouting.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController()
        {
            _productService = DependencyInjectionFake.GetProductService();
        }

        public ActionResult AllProducts()
        {
            return Json(_productService.GetAllProducts(), JsonRequestBehavior.AllowGet);
        }
    }
}