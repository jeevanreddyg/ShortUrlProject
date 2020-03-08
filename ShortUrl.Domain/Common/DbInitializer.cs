using ShortUrl.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortUrl.Domain.Common
{
    public static class DbInitializer
    {
        public static void Initialize(AppShortUrlContext context)
        {
            // Look for any Url's.
            if (context.Link.Any())
            {
                return;   // DB has been seeded
            }

            var links = new Link[]
            {
                new Link{ Id=1, LongUrl="http://sushumnakriyayoga.com",ShortUrl="http://dbsky.me/xF3sdf", 
                    CreatedDate=DateTime.Now, ModifiedDate=DateTime.Now, IsPurged=false }
            };
            foreach (var url in links)
            {
                context.Link.Add(url);
            }

            context.SaveChanges();
        }
    }
}
