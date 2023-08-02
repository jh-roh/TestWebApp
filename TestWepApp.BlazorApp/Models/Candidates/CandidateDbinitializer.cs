namespace TestWepApp.BlazorApp.Models.Candidates
{
    public static class CandidateDbinitializer
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                services.GetRequiredService<CandidateAppDbContext>();

                var candidateDbContext = services.GetRequiredService<CandidateAppDbContext>();

                if (!candidateDbContext.Candidates.Any(p => p.FirstName == "꺽정"))
                {
                    candidateDbContext.Candidates.Add(new Candidate { FirstName = "꺽정", LastName = "임", IsEnrollment = false });
                    candidateDbContext.SaveChanges();
                }
            }

        }
    }
}
