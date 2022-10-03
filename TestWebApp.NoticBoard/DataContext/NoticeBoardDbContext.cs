using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestWebApp.NoticBoard.Models;

namespace TestWebApp.NoticBoard.DataContext
{
    public class NoticeBoardDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }


        public NoticeBoardDbContext(DbContextOptions<NoticeBoardDbContext> options)
            : base(options)
        {
        }

    }
}
