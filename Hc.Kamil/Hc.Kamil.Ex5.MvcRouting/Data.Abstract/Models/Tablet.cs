using System;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models
{
    public class Tablet : Entity
    {
        public string Producer { get; set; }

        public string Model { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}