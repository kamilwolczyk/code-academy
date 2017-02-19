using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace HC.Radek.Ex5.Routing.Validators
{
    public class CodeStateValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var StateCodeString = (string)value;
                string Pattern = @"^[0-9]{2}-[0-9]{3}$";
                Regex RegExpression = new Regex(Pattern);
                Match Matcher = RegExpression.Match(StateCodeString);
                return !Matcher.Success ? new ValidationResult("Invalid City Code") : null;
            }catch
            {
                return new ValidationResult("Invalid City Code");
            }

        }
    }
}