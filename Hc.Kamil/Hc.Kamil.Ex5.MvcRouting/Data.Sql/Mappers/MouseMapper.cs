using System.Data.SqlClient;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;
using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Mappers
{
    public class MouseMapper : IEntityMapper<Mouse>
    {
        public Mouse Map(SqlDataReader reader)
        {
            return new Mouse
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                IsOptic = (bool)reader["IsOptic"]
            };
        }
    }
}