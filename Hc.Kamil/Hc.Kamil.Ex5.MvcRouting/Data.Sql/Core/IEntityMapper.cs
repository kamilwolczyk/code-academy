using System.Data.SqlClient;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core
{
    public interface IEntityMapper<out T> where T : Entity
    {
        T Map(SqlDataReader reader);
    }
}