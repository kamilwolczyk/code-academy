using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex6.Forms.Validators
{
    public class BirthDayValidation : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            int year = date.Year;
            if ((year < 1900) || date>DateTime.Now) return false;
            else return true;
        }
    }
}