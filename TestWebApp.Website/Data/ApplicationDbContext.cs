using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestWebApp.Website.Models;

namespace TestWebApp.Website.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TestWebApp.Website.Models.Blog> Blog { get; set; }
        public DbSet<TestWebApp.Website.Models.Post> Post { get; set; }
    }
}
