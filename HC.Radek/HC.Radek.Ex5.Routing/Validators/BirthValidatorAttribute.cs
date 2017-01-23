using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HC.Radek.Ex5.Routing.Validators
{
    public class BirthValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var birthString = (string)value;

            if (!IsEarlierThanToday(birthString))
                return new ValidationResult("You have to be older than 1 day");

            if (!IsOlderThan1900(birthString))
                return new ValidationResult("Birth date cannot be earlier than 1900-01-01");

            return !IsAdult(birthString) ? new ValidationResult("You are not adult person.") : null;
        }

        private bool IsEarlierThanToday(string personBirthDate)
        {
            var now = DateTime.Now;
            var s = new List<string>(personBirthDate.Split(new[] { "-" }, StringSplitOptions.None));
            var bDate = new DateTime(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), 23, 59, 59);

            var result = DateTime.Compare(now, bDate);

            return result > 0;
        }

        private bool IsOlderThan1900(string personBirthDate)
        {
            var s = new List<string>(personBirthDate.Split(new[] { "-" }, StringSplitOptions.None));
            var bDate = new DateTime(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), 0, 0, 0);
            var sDate = new DateTime(1900, 1, 1, 0, 0, 0);
            var result = DateTime.Compare(sDate, bDate);
            return result < 0;
        }

        private bool IsAdult(string personBirthDate)
        {
            var now = DateTime.Now;
            var s = new List<string>(personBirthDate.Split(new[] { "-" }, StringSplitOptions.None));
            var bDate = new DateTime(int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]), 23, 59, 59);
            return now.Year - bDate.Year > 18;
        }
    }
}