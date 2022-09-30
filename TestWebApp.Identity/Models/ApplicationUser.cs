using Microsoft.AspNetCore.Identity;

namespace TestWebApp.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
