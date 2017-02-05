using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Abstract.Models
{
    public class Computer
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Processor { get; set; }
        public int Ram { get; set; }

        public Computer(int id, string name, string processor, int ram)
        {
            Id = id;
            Name = name;
            Processor = processor;
            Ram = ram;
        }

        public Computer()
        {
        }
    }
}