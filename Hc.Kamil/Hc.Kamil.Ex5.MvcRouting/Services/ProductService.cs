using Hc.Kamil.Ex5.MvcRouting.Data.Abstract;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;

namespace Hc.Kamil.Ex5.MvcRouting.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Computer> _computerRepository;

        private readonly IRepository<Tablet> _tabletRepository;

        private readonly IRepository<Mouse> _mouseRepository;

        public ProductService(IRepository<Computer> computerRepository, IRepository<Tablet> tabletRepository, IRepository<Mouse> mouseRepository)
        {
            _computerRepository = computerRepository;
            _tabletRepository = tabletRepository;
            _mouseRepository = mouseRepository;
        }

        public AllProducts GetAllProducts()
        {
            return new AllProducts
            {
                Computers = _computerRepository.GetAll(),
                Tablets = _tabletRepository.GetAll(),
                Mouses = _mouseRepository.GetAll()
            };
        }
    }
}