using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestWepApp.BlazorApp.Models.Buffets;

namespace TestWepApp.BlazorApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Broth> Broths { get; set; }
        public DbSet<Noodle> Noodles { get; set; }
        public DbSet<Garnish> Garnishs { get; set; }

        /// <summary>
        /// 모델(테이블)이 생성될때 처음실행
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Broth>().HasData(
                new Broth() { Id = 1, Name = "콩국물", IsVegan = true },
                new Broth() { Id = 2, Name = "멸치국물", IsVegan = false }
            );

            builder.Entity<Noodle>().HasData(
                new Noodle() { Id = 1, Name = "콩국수", BrothId = 1 },
                new Noodle() { Id = 2, Name = "잔치국수", BrothId = 2 }
            );
        }
    }
}