using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql.Mappers
{
    public class ComputerMapper:BaseMapper<Computer>,IMapper<Computer>
    {

        public Computer Map(SqlDataReader data)
        {
            String className = "HC.Radek.Ex5.Routing.Data.Abstract.Models.Computer";
            return GetInstanceByName(className, data);
            //return GetInstance(new Computer(), data);
        }
    }
}