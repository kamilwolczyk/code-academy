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
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [Required]
        public int Wiek { get; set; }

        public string Adres { get; set; }
        
    }
}