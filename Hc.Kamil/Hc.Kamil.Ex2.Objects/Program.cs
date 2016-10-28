using Hc.Kamil.Ex2.Objects.UserInterface;

namespace Hc.Kamil.Ex2.Objects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IShop myShop = new Shop(new Salesman("Marek"), new StandardWarehouse());
            myShop.HandleCustomer();
        }
    }
}