using System.Collections.Generic;
using System.Data.SqlClient;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract;
using Hc.Kamil.Ex5.MvcRouting.Data.Abstract.Models;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core
{
    public class BaseRepository<T> : IRepository<T> where T : Entity
    {
        private readonly string _tableName;

        private readonly IEntityMapper<T> _entityMapper;

        public BaseRepository(string tableName, IEntityMapper<T> entityMapper)
        {
            _tableName = tableName;
            _entityMapper = entityMapper;
        }

        public T GetById(int id)
        {
            using (var connector = new SqlDbConnector())
            {
                var command = new SqlCommand($"SELECT TOP 1 * FROM {_tableName} WHERE Id=@Id;");
                command.Parameters.AddWithValue("@Id", id);

                var reader = connector.ExecuteQueryCommand(command);
                return !reader.Read() ? null : _entityMapper.Map(reader);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var connector = new SqlDbConnector())
            {
                var command = new SqlCommand($"SELECT * FROM {_tableName};");

                var reader = connector.ExecuteQueryCommand(command);
                var list = new List<T>();

                while (reader.Read())
                    list.Add(_entityMapper.Map(reader));

                return list;
            }
        }
    }
}