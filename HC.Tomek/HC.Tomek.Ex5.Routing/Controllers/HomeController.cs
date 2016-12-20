using HC.Tomek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HC.Tomek.Ex5.Routing.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string MainPage()
        {
            return "Witaj na stronie głównej czasomierza";
        }

        public string DateTime()
        {
            DateTimeModel dateTime = new DateTimeModel();
            return "Jest "+dateTime.GenerateDate("yyyy-MM-dd") +" godzina "+dateTime.GenerateTime("HH:mm");
        }

        public string Time(string format)
        {
            DateTimeModel dateTime = new DateTimeModel();
            return "Jest " + dateTime.GenerateTime(format);
        }

        public string Date(string format)
        {
            DateTimeModel dateTime = new DateTimeModel();
            return "Jest " + dateTime.GenerateDate(format);
        }
    }
}