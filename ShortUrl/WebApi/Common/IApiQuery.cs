using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Common
{
    interface IApiQuery<T>
    {
        T Run();
    }
}
