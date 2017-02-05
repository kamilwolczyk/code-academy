using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Repositories;
using Hc.Kamil.Ex5.MvcRouting.Services;

namespace Hc.Kamil.Ex5.MvcRouting.Configuration
{
    public class DependencyInjectionFake
    {
        public static IProductService GetProductService()
        {
            var computerRepository = new ComputerRepository();
            var tabletRepository = new TabletRepository();
            var mouseRepository = new MouseRepository();

            return new ProductService(computerRepository, tabletRepository, mouseRepository);
        }
    }
}