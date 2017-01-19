using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Models
{
    public class CarList
    {
        public CarList()
        {
            cars = new List<Car>();
        }
        public IList<Car> cars { get; set; }
                
    }
}