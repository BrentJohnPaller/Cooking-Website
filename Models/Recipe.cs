namespace CookingWebsite.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }
        public int Servings { get; set; }
        public string Difficulty { get; set; } = string.Empty;
        public List<string> Ingredients { get; set; } = new();
        public List<string> Steps { get; set; } = new();
        public string Author { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
        public int Likes { get; set; }
    }

    public class CookingTip
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }
}
