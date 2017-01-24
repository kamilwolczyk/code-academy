using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HC.Radek.Ex5.Routing.Validators
{
    public class BirthValidatorAttribute : ValidationAttribute
    {
        private List<string> birthDateList;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var birthString = (string)value;

            try
            {
                return ValidateData(birthString);
            }
            catch
            {
                return new ValidationResult("Invalid Birth Date");
            }


        }

        private ValidationResult ValidateData(String birthString)
        {
            if (!setBirthDate(birthString))
                return new ValidationResult("Invalid Birth Date format");

            if (!IsEarlierThanToday())
                return new ValidationResult("You have to be older than 1 day");

            if (!IsOlderThan1900())
                return new ValidationResult("Birth date cannot be earlier than 1900-01-01");

            return !IsAdult() ? new ValidationResult("You are not adult person.") : null;
        }

        private bool IsEarlierThanToday()
        {
            var now = DateTime.Now;
            var bDate = new DateTime(int.Parse(birthDateList[0]), int.Parse(birthDateList[1]), int.Parse(birthDateList[2]), 23, 59, 59);
            var result = DateTime.Compare(now, bDate);
            return result > 0;
        }

        private bool IsOlderThan1900()
        {
            
            var bDate = new DateTime(int.Parse(birthDateList[0]), int.Parse(birthDateList[1]), int.Parse(birthDateList[2]), 0, 0, 0);
            var sDate = new DateTime(1900, 1, 1, 0, 0, 0);
            var result = DateTime.Compare(sDate, bDate);
            return result < 0;
        }

        private bool IsAdult()
        {
            var now = DateTime.Now;
            var bDate = new DateTime(int.Parse(birthDateList[0]), int.Parse(birthDateList[1]), int.Parse(birthDateList[2]), 23, 59, 59);
            return now.Year - bDate.Year > 18;
        }

        private bool setBirthDate(string personBirthDate)
        {
            birthDateList = new List<string>(personBirthDate.Split(new[] { "-" }, StringSplitOptions.None));
            return birthDateList.Count == 3;
        }
    }
}