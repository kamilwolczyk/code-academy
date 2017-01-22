using HC.Tomek.Ex5.Routing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex5.Routing.Services
{
    public class PersonService
    {
        public Person GetPerson(Person person, int? id)
        {
            person.Imie = "Janusz";
            if (id.HasValue)
                person.Wiek = 30 + (int)id;
            else
                person.Wiek = 30;
            return person;
        }
    }
}