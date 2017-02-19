using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql.Mappers
{
    public class TabletMapper : BaseMapper<Tablet>,IMapper<Tablet>
    {
        public Tablet Map(SqlDataReader data)
        {
            //String className = "HC.Radek.Ex5.Routing.Data.Abstract.Models.Tablet";
            //return GetInstanceByName(className, data);
            return GetInstance(new Tablet(), data);
        }
    }
}