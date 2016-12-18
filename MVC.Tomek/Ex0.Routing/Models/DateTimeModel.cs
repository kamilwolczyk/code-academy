using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Ex0.Routing.Models
{
    public class DateTimeModel
    {
        public string GenerateDate()
        {
            string _date="";
            DateTime _localDate = DateTime.Now;
            _date = _localDate.ToString("yyyy-MM-dd");
            return _date;
        }

        public string GenerateTime()
        {
            string _time = "";
            DateTime _localTime = DateTime.Now;
            _time = _localTime.ToString("HH:mm");
            return _time;
        }

        //public string GenerateTime(string _format)
        //{
        //    string _time = "";
        //    DateTime _localTime = DateTime.Now;
        //    _time = _localTime.ToString(_format);
        //    return _time;
        //}
    }
}