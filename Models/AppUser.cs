using Microsoft.AspNetCore.Identity;

namespace CookingWebsite.Models
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; } = string.Empty;
        public string? ProfilePhotoUrl { get; set; }
        public string? Bio { get; set; }
        public DateTime JoinedDate { get; set; } = DateTime.Now;
    }
}