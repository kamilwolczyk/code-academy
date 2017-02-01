using System.Collections.Generic;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models
{
    public class AllProducts
    {
        public IEnumerable<Computer> Computers { get; set; }

        public IEnumerable<Tablet> Tablets { get; set; }

        public IEnumerable<Mouse> Mouses { get; set; }
    }
}