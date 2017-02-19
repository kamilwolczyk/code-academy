using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex5.Routing.Data.Sql.Mappers
{
    public interface IMapper<out T>
    {
        T Map(SqlDataReader data);
    }
}
