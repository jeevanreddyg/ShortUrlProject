using ShortUrl.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Link
{
    public class LinkMapper : IApiResource<Domain.Link, LinkResource>
    {   
        public LinkResource Map(Domain.Link entity)
        {
            var resource = new LinkResource();

            resource.Id = entity.Id;
            resource.LongUrl = entity.LongUrl;
            resource.ShortUrl = entity.ShortUrl;
            resource.CreatedDate = entity.CreatedDate;
            return resource;
        }

        public IEnumerable<LinkResource> Map(IEnumerable<Domain.Link> lstEntity)
        {
            List<LinkResource> lstResource = new List<LinkResource>();
           
            foreach (var entity in lstEntity)
            {
               lstResource.Add(Map(entity));
            }
            
            return lstResource;
        }
    }
}
