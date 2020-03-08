using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ShortUrl.Domain.Common;

namespace ShortUrl.Domain
{
    public class LinkRepository : ILinkRepository
    {
        private readonly ApplicationDbContext _context;
        private static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        private static List<char> characters = new List<char>()
        {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B',
        'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
        'Q', 'R', 'S',  'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
        private static string ShortBaseUrl = "http://dbsky.me/";


        public LinkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Link> GetAll()
        {
            return _context.Link.ToList();
        }

        public Link GetById(int linkId)
        {
            return _context.Link.Find(linkId);
        }

        public Link Add(Link link)
        {
            var linkObject = _context.Link.Add(link);
            _context.SaveChanges();
            return linkObject.Entity;
        }

        public Link CreateShortUrl(string longUrl)
        {
            Link link = new Link
            {
                LongUrl = longUrl,
                ShortUrl = GenerateShortUrl(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                IsPurged = false
            };
            return Add(link);
        }

        private string GenerateShortUrl()
        {
            string randomString = "";
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int random = rand.Next(0, 3);
                if (random == 1)
                {
                    random = rand.Next(0, numbers.Count);
                    randomString += numbers[random].ToString();
                }
                else
                {
                    random = rand.Next(0, characters.Count);
                    randomString += characters[random].ToString();
                }
            }
            
            return ShortBaseUrl + randomString;
        }
    }
}
