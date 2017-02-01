using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;
using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core;
using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Mappers;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Repositories
{
    public class TabletRepository : BaseRepository<Tablet>
    {
        public TabletRepository() : base("Tablet", new TabletMapper())
        { }
    }
}