using HC.Tomek.Ex6.Forms.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex6.Forms.Models
{
    public class Person
    {
        [Required]
        [Display(Name ="Name")]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int StreetNumber { get; set; }

        [Required]
        [StringLength(6)]
        [RegularExpression("[0-9]{2}-[0-9]{3}")]
        public string Postcode { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        [BirthDayValidation(ErrorMessage ="BirthDate is not correct")]
        public DateTime BirthDay { get; set; }
    }
}