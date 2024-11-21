namespace EpsilonLocal.Models
{
    public class AppUser: Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string FullName { get; set; }

        public int Password { get; set; }
    }
}
