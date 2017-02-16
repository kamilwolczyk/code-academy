using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using HC.Radek.Ex5.Routing.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Abstract.Services
{
    public class ProductsService
    {
        private ComputerRepository _computerRepository;
        private TabletRepository _tabletRepository;

        public ProductsService()
        {
            _computerRepository = new ComputerRepository();
            _tabletRepository = new TabletRepository();
        }

        public IList<Computer> getComputers()
        {
            return _computerRepository.getComputers();
        }

        public IList<Tablet> getTablets()
        {
            return _tabletRepository.getTablets();
        }

    }
}