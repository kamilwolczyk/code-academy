using System.ComponentModel.DataAnnotations;
using HC.Radek.Ex5.Routing.Validators;

namespace HC.Radek.Ex5.Routing.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string CityCode { get; set; }

        [Required]
        [BirthValidator]
        [Display(Name = "Birth date (yyyy - mm - dd)")]
        public string BirthDate { get; set; }
    }
}