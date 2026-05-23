using System.ComponentModel.DataAnnotations;

namespace CookingWebsite.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string DisplayName { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;

        [Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }

    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }
    }

    public class EditProfileViewModel
    {
        [Required]
        public string DisplayName { get; set; } = string.Empty;

        public string? Bio { get; set; }

        public string? CurrentPhotoUrl { get; set; }

        public IFormFile? ProfilePhoto { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        public string CurrentPassword { get; set; } = string.Empty;

        [Required, MinLength(6)]
        public string NewPassword { get; set; } = string.Empty;

        [Compare("NewPassword", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}