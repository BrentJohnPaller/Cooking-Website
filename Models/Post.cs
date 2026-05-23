using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingWebsite.Models
{
    public enum PostType { Recipe, Video, Tip, Photo }

    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public PostType Type { get; set; }

        [Required]
        public string Author { get; set; } = string.Empty;

        public string AuthorAvatar { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int Likes { get; set; } = 0;
        public int Comments { get; set; } = 0;

        // Recipe
        public string? PhotoUrl { get; set; }
        public string? AdditionalPhoto2 { get; set; }
        public string? AdditionalPhoto3 { get; set; }
        public string? Category { get; set; }
        public string? Difficulty { get; set; }
        public int? CookTimeMinutes { get; set; }
        public int? PrepTimeMinutes { get; set; }
        public int? Servings { get; set; }
        public string? Ingredients { get; set; }
        public string? Steps { get; set; }

        // Video
        public string? VideoEmbedUrl { get; set; }
        public string? VideoThumbnail { get; set; }
        public string? VideoDuration { get; set; }

        // Tip
        public string? TipIcon { get; set; }
        public string? TipCategory { get; set; }

        // Computed helpers (not stored in DB)
        [NotMapped]
        public List<string> PhotoList =>
            new[] { PhotoUrl, AdditionalPhoto2, AdditionalPhoto3 }
            .Where(p => !string.IsNullOrEmpty(p))
            .Select(p => p!)
            .ToList();

        [NotMapped]
        public List<string> IngredientList =>
            string.IsNullOrEmpty(Ingredients) ? new() :
            Ingredients.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).Where(s => s.Length > 0).ToList();

        [NotMapped]
        public List<string> StepList =>
            string.IsNullOrEmpty(Steps) ? new() :
            Steps.Split('\n', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).Where(s => s.Length > 0).ToList();
    }

    public class CreatePostViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public PostType Type { get; set; }
        public string Author { get; set; } = string.Empty;
        public IFormFile? Photo1 { get; set; }
        public IFormFile? Photo2 { get; set; }
        public IFormFile? Photo3 { get; set; }

        public string? Category { get; set; }
        public string? Difficulty { get; set; }
        public int? CookTimeMinutes { get; set; }
        public int? PrepTimeMinutes { get; set; }
        public int? Servings { get; set; }
        public string? Ingredients { get; set; }
        public string? Steps { get; set; }
        public string? VideoEmbedUrl { get; set; }
        public string? TipIcon { get; set; }
        public string? TipCategory { get; set; }
    }
}