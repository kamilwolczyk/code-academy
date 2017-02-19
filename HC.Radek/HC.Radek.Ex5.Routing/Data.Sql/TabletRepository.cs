using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using HC.Radek.Ex5.Routing.Data.Sql.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql
{
    public class TabletRepository : BaseRepository<Tablet>
    {

        public TabletRepository():base(new TabletMapper())
        {

        }

        public IList<Tablet> getTablets()
        {
            return getProducts("select * from Tablet;");
        }

    }
}