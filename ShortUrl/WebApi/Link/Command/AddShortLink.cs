using ShortUrl.Domain;
using ShortUrl.WebApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Link.Command
{
    public class AddShortLink: IApiCommand<LinkResource>
    {
        private readonly ILinkRepository _repository;
        private LinkResource _linkResource;
        public AddShortLink(ILinkRepository repository, LinkResource linkResource)
        {
            _repository = repository;
            _linkResource = linkResource;
        }
        public LinkResource Execute()
        {
            var link = _repository.CreateShortUrl(_linkResource.LongUrl);
            LinkMapper mapper = new LinkMapper();
            return mapper.Map(link);
        }
    }
}
