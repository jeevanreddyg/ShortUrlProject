using System;
using System.ComponentModel.DataAnnotations;

namespace ShortUrl.Domain
{
    public class Link
    {
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsPurged { get; set; }
    }
}
