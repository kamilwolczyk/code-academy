using System.Web.Mvc;
using Hc.Kamil.Ex5.MvcRouting.Models;
using Hc.Kamil.Ex5.MvcRouting.Services;

namespace Hc.Kamil.Ex5.MvcRouting.Controllers
{
    public class DateController : Controller
    {
        private readonly IDateService _dateService;

        public DateController()
        {
            _dateService = new DateService();
        }

        public string Hello()
        {
            return "Witaj na stronie głównej czasomierza";
        }

        public string DateTime(string format)
        {
            return _dateService.GetDateString(DateType.DateTime, format);
        }

        public string Date(string format)
        {
            return _dateService.GetDateString(DateType.Date, format);
        }

        public string Hour(string format)
        {
            return _dateService.GetDateString(DateType.Time, format);
        }
    }
}