using CookingWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CookingWebsite.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.ParentComment)
                .WithMany(c => c.Replies)
                .HasForeignKey(c => c.ParentCommentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany()
                .HasForeignKey(c => c.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PostLike>()
                .HasIndex(pl => new { pl.PostId, pl.UserId })
                .IsUnique();

            modelBuilder.Entity<CommentLike>()
                .HasIndex(cl => new { cl.CommentId, cl.UserId })
                .IsUnique();

            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Type = PostType.Recipe,
                    Title = "My Grandma's Chicken Adobo — Finally Perfected It!",
                    Content = "After 3 years of trying, I finally nailed my grandmother's chicken adobo. The secret is coconut vinegar and letting it rest overnight.",
                    Author = "Maria Santos",
                    AuthorAvatar = "MS",
                    DatePosted = new DateTime(2026, 3, 1),
                    Likes = 0,
                    Comments = 0,
                    PhotoUrl = "https://www.seriouseats.com/thmb/uc8nb040OwgXekR9obuhEqm8WoI=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__2019__10__20191023-chicken-adobo-vicky-wasik-19-12ce105a2e1a44dfb1e2673775118064.jpg",
                    Category = "Filipino",
                    Difficulty = "Medium",
                    CookTimeMinutes = 60,
                    PrepTimeMinutes = 15,
                    Servings = 4,
                    Ingredients = "1 kg chicken thighs\n1/2 cup coconut vinegar\n1/4 cup soy sauce\n1 head garlic, crushed\n3 bay leaves\n1 tsp black peppercorns\n1 cup water",
                    Steps = "Combine chicken, vinegar, soy sauce, garlic, bay leaves, peppercorns, and water in a pot.\nMarinate for at least 1 hour, overnight is best.\nBring to a boil then simmer for 30 minutes covered.\nUncover and reduce sauce until it thickens."
                },
                new Post
                {
                    Id = 2,
                    Type = PostType.Tip,
                    Title = "Always Bloom Your Spices First",
                    Content = "Toast dry spices in a dry pan for 30 to 60 seconds before using them. This blooming releases essential oils and dramatically deepens the flavor.",
                    Author = "Priya Nair",
                    AuthorAvatar = "PN",
                    DatePosted = new DateTime(2026, 3, 5),
                    Likes = 0,
                    Comments = 0,
                    TipIcon = "🌶️",
                    TipCategory = "Spices & Seasoning"
                }
            );
        }
    }
}