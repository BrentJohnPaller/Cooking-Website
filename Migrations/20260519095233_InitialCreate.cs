using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CookingWebsite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorAvatar = table.Column<string>(type: "TEXT", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Likes = table.Column<int>(type: "INTEGER", nullable: false),
                    Comments = table.Column<int>(type: "INTEGER", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    AdditionalPhoto2 = table.Column<string>(type: "TEXT", nullable: true),
                    AdditionalPhoto3 = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Difficulty = table.Column<string>(type: "TEXT", nullable: true),
                    CookTimeMinutes = table.Column<int>(type: "INTEGER", nullable: true),
                    PrepTimeMinutes = table.Column<int>(type: "INTEGER", nullable: true),
                    Servings = table.Column<int>(type: "INTEGER", nullable: true),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Steps = table.Column<string>(type: "TEXT", nullable: true),
                    VideoEmbedUrl = table.Column<string>(type: "TEXT", nullable: true),
                    VideoThumbnail = table.Column<string>(type: "TEXT", nullable: true),
                    VideoDuration = table.Column<string>(type: "TEXT", nullable: true),
                    TipIcon = table.Column<string>(type: "TEXT", nullable: true),
                    TipCategory = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AdditionalPhoto2", "AdditionalPhoto3", "Author", "AuthorAvatar", "Category", "Comments", "Content", "CookTimeMinutes", "DatePosted", "Difficulty", "Ingredients", "Likes", "PhotoUrl", "PrepTimeMinutes", "Servings", "Steps", "TipCategory", "TipIcon", "Title", "Type", "VideoDuration", "VideoEmbedUrl", "VideoThumbnail" },
                values: new object[,]
                {
                    { 1, "https://images.unsplash.com/photo-1547592180-85f173990554?w=700", "https://images.unsplash.com/photo-1504674900247-0877df9cc836?w=700", "Maria Santos", "MS", "Filipino", 14, "After 3 years of trying, I finally nailed my grandmother's chicken adobo. The secret is coconut vinegar and letting it rest overnight. The flavors deepen beautifully. Every bite brings me right back to her kitchen in Cebu.", 60, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medium", "1 kg chicken thighs\n1/2 cup coconut vinegar\n1/4 cup soy sauce\n1 head garlic, crushed\n3 bay leaves\n1 tsp black peppercorns\n1 cup water", 87, "https://images.unsplash.com/photo-1626200419199-391ae4be7a41?w=700", 15, 4, "Combine chicken, vinegar, soy sauce, garlic, bay leaves, peppercorns, and water in a pot.\nMarinate for at least 1 hour, overnight is best.\nBring to a boil then simmer for 30 minutes covered.\nUncover and reduce sauce until it thickens and coats the chicken.\nOptional: fry chicken pieces in oil until golden before serving.", null, null, "My Grandma's Chicken Adobo — Finally Perfected It!", 0, null, null, null },
                    { 2, null, null, "Chef James", "CJ", null, 22, "One of the most useful knife skills you can learn. Uniform cuts mean even cooking. I demonstrate on carrots, zucchini, and bell peppers. Watch till the end for the pro tip on keeping your fingers safe!", null, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 134, null, null, null, null, null, null, "How to Julienne Vegetables Perfectly — 3-Minute Tutorial", 1, "3:24", "https://www.youtube.com/embed/dQw4w9WgXcQ", "https://images.unsplash.com/photo-1556909114-f6e7ad7d3136?w=700" },
                    { 3, null, null, "Priya Nair", "PN", null, 31, "Toast dry spices in a dry pan for 30 to 60 seconds before using them. This blooming releases essential oils and dramatically deepens the flavor. Works for cumin, coriander, paprika — any whole or ground spice. A 1-minute step that makes a massive difference.", null, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 203, null, null, null, null, "Spices & Seasoning", "🌶️", "Always Bloom Your Spices First", 2, null, null, null },
                    { 4, "https://images.unsplash.com/photo-1567620905732-2d1ec7ab7445?w=700", null, "Elena Cruz", "EC", "Breakfast", 9, "Made this for the whole family last weekend and it was gone in minutes. The trick is day-old brioche — it soaks up the custard without getting soggy. I add cream cheese and strawberry jam in the middle. Game changer for brunch!", 45, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easy", "1 loaf day-old brioche, cubed\n4 large eggs\n1.5 cups milk\n1/2 cup heavy cream\n3 tbsp maple syrup\n1 tsp vanilla extract\n200g cream cheese\n3 tbsp strawberry jam\nPowdered sugar for serving", 56, "https://images.unsplash.com/photo-1484723091739-30a097e8f929?w=700", 10, 6, "Grease a 9x13 baking dish. Place half the brioche cubes inside.\nMix cream cheese and jam; dollop over the bread layer.\nTop with remaining brioche cubes.\nWhisk eggs, milk, cream, maple syrup, and vanilla. Pour over bread.\nPress down gently; cover and refrigerate overnight or 1 hour.\nBake at 175C for 40-45 minutes until golden and puffed.\nDust with powdered sugar and serve with extra maple syrup.", null, null, "Sunday Morning French Toast Bake", 0, null, null, null },
                    { 5, null, null, "Chef Antoine", "CA", null, 47, "There is nothing more satisfying than making pasta with your own hands. I walk through everything: flour ratio, kneading, resting time, and rolling. No pasta machine needed — just a rolling pin and patience.", null, new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 289, null, null, null, null, null, null, "Homemade Pasta from Scratch — Full Process", 1, "12:07", "https://www.youtube.com/embed/dQw4w9WgXcQ", "https://images.unsplash.com/photo-1556909114-f6e7ad7d3136?w=700" },
                    { 6, null, null, "Sarah Kim", "SK", null, 19, "When making pie crust, biscuits, or scones, your butter must be ice cold. Warm butter melts into the flour and creates a dense texture. Cold butter creates steam pockets while baking, resulting in light, flaky layers. Cut into cubes and freeze 15 minutes before using.", null, new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 178, null, null, null, null, "Baking", "🧈", "Use Cold Butter for Flakier Pastry", 2, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
