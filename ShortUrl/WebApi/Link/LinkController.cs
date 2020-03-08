using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShortUrl.Domain;
using ShortUrl.WebApi.Link;
using ShortUrl.WebApi.Link.Command;
using ShortUrl.WebApi.Link.Query;

namespace ShortUrl.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkRepository _repository;

        public LinkController(ILinkRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Link
        [HttpGet]
        public IEnumerable<LinkResource> GetUrls()
        {
            return new GetAllLinks(_repository).Run();
        }

        // GET: api/Link/5
        [HttpGet("{id}")]
        public ActionResult<LinkResource> GetById(int id)
        {
            var urlModel = new GetById(_repository,id).Run();

            if (urlModel == null)
            {
                return NotFound();
            }

            return urlModel;
        }

        // POST: api/Url
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [Route("createshortlink")]
        [HttpPost]
        public ActionResult<LinkResource> PostLink([FromBody]LinkResource longUrl)
        {
            var urlModel = new AddShortLink(_repository, longUrl).Execute();

            if (urlModel == null)
            {
                return NotFound();
            }

            return urlModel;
        }
    }
}
