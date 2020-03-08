using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShortUrl.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortUrl.Domain
{
    public class AppShortUrlContext : IdentityDbContext<IdentityUser>
    {
        public AppShortUrlContext(DbContextOptions<AppShortUrlContext> options) : base(options)
        { 
        
        }
        public DbSet<Link> Link { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Link>().ToTable("Link");
        //}
    } 
}
