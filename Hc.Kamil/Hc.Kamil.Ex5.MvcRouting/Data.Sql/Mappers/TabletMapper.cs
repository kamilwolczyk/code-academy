using System;
using System.Data.SqlClient;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;
using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Mappers
{
    public class TabletMapper : IEntityMapper<Tablet>
    {
        public Tablet Map(SqlDataReader reader)
        {
            return new Tablet
            {
                Id = (int)reader["Id"],
                Producer = (string)reader["Producer"],
                Model = (string)reader["Model"],
                DeliveryDate = (DateTime)reader["DeliveryDate"]
            };
        }
    }
}