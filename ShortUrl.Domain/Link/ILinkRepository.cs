using System;
using System.Collections.Generic;
using System.Text;

namespace ShortUrl.Domain
{
    public interface ILinkRepository
    {
        Link CreateShortUrl(string longUrl);

        IEnumerable<Link> GetAll();

        Link GetById(int urlId);
    }
}
