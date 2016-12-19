using System;
using System.Collections.Generic;
using Hc.Kamil.Ex5.MvcRouting.Models;

namespace Hc.Kamil.Ex5.MvcRouting.Services
{
    public class DateService : IDateService
    {
        private readonly IDictionary<DateType, string> _defaultFormats = new Dictionary<DateType, string>
        {
            { DateType.DateTime, "yyyy-MM-dd HH:mm" },
            { DateType.Date, "yyyy-MM-dd" },
            { DateType.Time, "HH:mm" }
        };

        public string GetDateString(DateType type, string format)
        {
            var date = !string.IsNullOrEmpty(format)
                ? DateTime.Now.ToString(format)
                : DateTime.Now.ToString(_defaultFormats[type]);

            return $"Jest {date}";
        }
    }
}