using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Abstract.Models
{
    public class Tablet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }


        public Tablet(int id, string name, int width, int height)
        {
            Id = id;
            Name = name;
            Width = width;
            Height = height;
        }

        public Tablet()
        {

        }

    }
}