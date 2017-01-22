using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Tomek.Ex5.Routing.Models
{
    public class CarList
    {
        public CarList()
        {
            Cars = new List<Car>();
        }
        public IList<Car> Cars { set; get; }
    }
}