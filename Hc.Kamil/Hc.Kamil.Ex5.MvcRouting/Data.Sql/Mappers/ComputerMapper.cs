using System.Data.SqlClient;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;
using Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Mappers
{
    public class ComputerMapper : IEntityMapper<Computer>
    {
        public Computer Map(SqlDataReader reader)
        {
            return new Computer
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Processor = (string)reader["Processor"],
                Ram = (int)reader["Ram"]
            };
        }
    }
}