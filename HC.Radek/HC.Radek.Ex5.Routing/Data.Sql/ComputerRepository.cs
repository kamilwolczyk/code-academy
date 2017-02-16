using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using HC.Radek.Ex5.Routing.Data.Sql.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql
{
    public class ComputerRepository:BaseRepository<Computer>
    {
 
        public ComputerRepository():base(new ComputerMapper())
        {

        }

        public IList<Computer> getComputers()
        {
            return getProducts("select * from Computer;");
        }

    }
}