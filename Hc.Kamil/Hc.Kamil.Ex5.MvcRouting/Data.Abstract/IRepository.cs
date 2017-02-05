using System.Collections.Generic;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Abstract
{
    public interface IRepository<out T>
    {
        T GetById(int id);

        IEnumerable<T> GetAll();
    }
}