using ShortUrl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.WebApi.Link.Query
{
    public class GetById
    {
        private readonly ILinkRepository _repository;
        private int _linkId;
        public GetById(ILinkRepository repository, int linkId)
        {
            _repository = repository;
            _linkId = linkId;
        }
        public LinkResource Run()
        {
            var link = _repository.GetById(_linkId);
            LinkMapper mapper = new LinkMapper();
            return mapper.Map(link);
        }
    }
}
