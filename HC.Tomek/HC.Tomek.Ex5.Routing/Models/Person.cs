using HC.Tomek.Ex5.Routing.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex5.Routing.Models
{
    public class Person
    {
        [Required]
        [Display(Name ="Name")]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [GreaterThan(18)]
        public int Age { get; set; }

        public string Address { get; set; }
        
    }
}