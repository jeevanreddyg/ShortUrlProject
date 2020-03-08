using ShortUrl.Domain;
using ShortUrl.Domain.Common;
using ShortUrl.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Link.Query
{
    public class GetAllLinks 
    {
        private readonly ILinkRepository _repository;
        public GetAllLinks(ILinkRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<LinkResource> Run()
        {
            var links = _repository.GetAll();
            LinkMapper mapper = new LinkMapper();
            return mapper.Map(links);
        }
    }
}
