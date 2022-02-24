using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Services
{
    public interface ISingleUserRepo <K, T>
    {
        Task<IEnumerable<T>> GetAll(K k);
    }
}
