using HC.Radek.Ex5.Routing.Data.Abstract.Models;
using HC.Radek.Ex5.Routing.Data.Sql.Mappers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql
{
    public abstract class BaseRepository<T>
    {
        protected SqlConnector sqlConnector;
        public IMapper<T> mapper;

        public BaseRepository(IMapper<T> _mapper)
        {
            mapper = _mapper;
            sqlConnector = new SqlConnector();
        }

        protected IList<T> getProducts(String sql)
        {
            IList<T> productList = new List<T>();
            SqlDataReader sqlDataReader = getReader(sql);
            while (sqlDataReader.Read())
            {
                productList.Add(map(sqlDataReader));
            }
            close();
            return productList;
        }

        private T map(SqlDataReader reader)
        {
            return mapper.Map(reader);
            //return (T) Convert.ChangeType(mapper.Map(reader),typeof(T));
        }

        private SqlDataReader getReader(String sql)
        {
            sqlConnector.connect();
            return new SqlCommand(sql, sqlConnector.getConnection()).ExecuteReader();
        }

        private void close()
        {
            sqlConnector.close();
        }
    }
}