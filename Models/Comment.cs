using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingWebsite.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime DatePosted { get; set; } = DateTime.Now;
        public int Likes { get; set; } = 0;

        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;

        public int? ParentCommentId { get; set; }
        public Comment? ParentComment { get; set; }

        public List<Comment> Replies { get; set; } = new();
        public List<CommentLike> CommentLikes { get; set; } = new();
    }

    public class PostLike
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;
    }

    public class CommentLike
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; } = null!;
        public string UserId { get; set; } = string.Empty;
        public AppUser User { get; set; } = null!;
    }
}