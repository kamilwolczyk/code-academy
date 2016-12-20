using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex5.Routing.Models
{
    public class DateTimeModel
    {
        public string GenerateDate(string format)
        {
            string date="";
            DateTime _localDate = DateTime.Now;
            if (format == null)
                date = _localDate.ToString("yyyy-MM-dd");
            else
                date = _localDate.ToString(format);
            return date;
        }

        public string GenerateTime(string format)
        {
            string time = "";
            DateTime _localTime = DateTime.Now;
            if (format == null)
                time = _localTime.ToString("HH:mm");
            else
                time = _localTime.ToString(format);
            return time;
        }

        
    }
}