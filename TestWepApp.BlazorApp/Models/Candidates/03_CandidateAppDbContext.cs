using Microsoft.EntityFrameworkCore;

namespace TestWepApp.BlazorApp.Models.Candidates
{
    public class CandidateAppDbContext : DbContext
    {
        public CandidateAppDbContext() : base()
        {
            
        }
        public CandidateAppDbContext(DbContextOptions<CandidateAppDbContext> options) : base(options)
        {

        }

        public DbSet<Candidate> Candidates { get; set; } = null!;
    }
}
