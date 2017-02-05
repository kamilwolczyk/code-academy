using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex5.Routing.Validators
{
    public class GreaterThan : ValidationAttribute
    {
        //public override ValidationResult IsValid(object value, ValidationContext context)
        //{
        //    return base.IsValid(value);
        //}
        public GreaterThan(int boundaryValue)
        {
            BoundaryValue = boundaryValue;
        }

        public int BoundaryValue { get; set; }

        public override bool IsValid(object value)
        {
            int x = (int)value;
            if (x < BoundaryValue) return false;
            else return true;
        }
    }
}