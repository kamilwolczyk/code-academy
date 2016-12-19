using Ex0.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ex0.Routing.Controllers
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
            DateTimeModel _dateTime = new DateTimeModel();
            return "Jest "+_dateTime.GenerateDate()+" godzina "+_dateTime.GenerateTime();
        }

        public string Time()
        {
            DateTimeModel _dateTime = new DateTimeModel();
            return "Jest " + _dateTime.GenerateTime();
        }

        //public string Time(string _format)
        //{
        //    DateTimeModel _dateTime = new DateTimeModel();
        //    return "Jest " + _dateTime.GenerateTime(_format);
        //}

        public string Date()
        {
            DateTimeModel _dateTime = new DateTimeModel();
            return "Jest " + _dateTime.GenerateDate();
        }
    }
}