using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql.Mappers
{
    public class BaseMapper<T>
    {
        private T instance;

        public T GetInstanceByName(string strFullyQualifiedName, SqlDataReader data)
        {
            instance = SetEmptyInstance(strFullyQualifiedName);
            SetData(data);
            return instance;
        }
        public T GetInstance(T _instance, SqlDataReader data)
        {
            instance = _instance;
            SetData(data);
            return instance;
        }
        private T SetEmptyInstance(string strFullyQualifiedName)
        {
            Type t = Type.GetType(strFullyQualifiedName);
            return (T) Activator.CreateInstance(t);
        }

        private void SetData(SqlDataReader data)
        {
            foreach (var prop in instance.GetType().GetProperties())
            {
                prop.SetValue(instance, data[prop.Name], null);
            }
        }

    }
}