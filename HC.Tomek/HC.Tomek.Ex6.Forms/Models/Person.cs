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
        public string Postcode { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        [BirthDayValidation()]
        public DateTime BirthDay { get; set; }
    }
}