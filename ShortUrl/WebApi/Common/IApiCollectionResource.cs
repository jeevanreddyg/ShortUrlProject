using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Common
{
    public interface IApiCollectionResource<T>
    {
        public IEnumerable<T> Entities { get; set; }
    }
}
