using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Services
{
    public interface IRepo<K, T>
    {
        void GetToken(string token);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(K key);
        Task<T> Add(T item);
        Task<T> Delete(K key);
        Task<T> Update(T item);
    }
}
