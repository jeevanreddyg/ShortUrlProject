using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Common
{
    public interface IApiResource<T1, T2>
    {
        public T2 Map(T1 entity);
    }
}
