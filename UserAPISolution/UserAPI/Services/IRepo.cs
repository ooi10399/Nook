using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.Services
{
    public interface IRepo<K, T>
    {
        ICollection<T> GetAll();
        T Get(K key);
        T Add(T item);
        T Delete(K key);
        T Update(T item);
    }
}
