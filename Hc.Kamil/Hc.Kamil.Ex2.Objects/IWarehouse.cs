using System.Collections.Generic;
using Hc.Kamil.Ex2.Objects.Models;

namespace Hc.Kamil.Ex2.Objects
{
    public interface IWarehouse
    {
        void AddProduct(Product product);

        bool TryGetProduct(Product product);

        IEnumerable<Product> GetAvailableProducts();
    }
}