using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CookingWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityAndComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    ProfilePhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    JoinedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    DatePosted = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Likes = table.Column<int>(type: "INTEGER", nullable: false),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ParentCommentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Comments_ParentCommentId",
                        column: x => x.ParentCommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentLikes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentLikes_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalPhoto2", "AdditionalPhoto3", "Comments", "Content", "Likes", "Steps" },
                values: new object[] { null, null, 0, "After 3 years of trying, I finally nailed my grandmother's chicken adobo. The secret is coconut vinegar and letting it rest overnight.", 0, "Combine chicken, vinegar, soy sauce, garlic, bay leaves, peppercorns, and water in a pot.\nMarinate for at least 1 hour, overnight is best.\nBring to a boil then simmer for 30 minutes covered.\nUncover and reduce sauce until it thickens." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "AuthorAvatar", "Comments", "Content", "DatePosted", "Likes", "TipCategory", "TipIcon", "Title", "Type", "VideoDuration", "VideoEmbedUrl", "VideoThumbnail" },
                values: new object[] { "Priya Nair", "PN", 0, "Toast dry spices in a dry pan for 30 to 60 seconds before using them. This blooming releases essential oils and dramatically deepens the flavor.", new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Spices & Seasoning", "🌶️", "Always Bloom Your Spices First", 2, null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_CommentId_UserId",
                table: "CommentLikes",
                columns: new[] { "CommentId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommentLikes_UserId",
                table: "CommentLikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ParentCommentId",
                table: "Comments",
                column: "ParentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId_UserId",
                table: "PostLikes",
                columns: new[] { "PostId", "UserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_UserId",
                table: "PostLikes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CommentLikes");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdditionalPhoto2", "AdditionalPhoto3", "Comments", "Content", "Likes", "Steps" },
                values: new object[] { "https://images.unsplash.com/photo-1547592180-85f173990554?w=700", "https://images.unsplash.com/photo-1504674900247-0877df9cc836?w=700", 14, "After 3 years of trying, I finally nailed my grandmother's chicken adobo. The secret is coconut vinegar and letting it rest overnight. The flavors deepen beautifully. Every bite brings me right back to her kitchen in Cebu.", 87, "Combine chicken, vinegar, soy sauce, garlic, bay leaves, peppercorns, and water in a pot.\nMarinate for at least 1 hour, overnight is best.\nBring to a boil then simmer for 30 minutes covered.\nUncover and reduce sauce until it thickens and coats the chicken.\nOptional: fry chicken pieces in oil until golden before serving." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "AuthorAvatar", "Comments", "Content", "DatePosted", "Likes", "TipCategory", "TipIcon", "Title", "Type", "VideoDuration", "VideoEmbedUrl", "VideoThumbnail" },
                values: new object[] { "Chef James", "CJ", 22, "One of the most useful knife skills you can learn. Uniform cuts mean even cooking. I demonstrate on carrots, zucchini, and bell peppers. Watch till the end for the pro tip on keeping your fingers safe!", new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 134, null, null, "How to Julienne Vegetables Perfectly — 3-Minute Tutorial", 1, "3:24", "https://www.youtube.com/embed/dQw4w9WgXcQ", "https://images.unsplash.com/photo-1556909114-f6e7ad7d3136?w=700" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "AdditionalPhoto2", "AdditionalPhoto3", "Author", "AuthorAvatar", "Category", "Comments", "Content", "CookTimeMinutes", "DatePosted", "Difficulty", "Ingredients", "Likes", "PhotoUrl", "PrepTimeMinutes", "Servings", "Steps", "TipCategory", "TipIcon", "Title", "Type", "VideoDuration", "VideoEmbedUrl", "VideoThumbnail" },
                values: new object[,]
                {
                    { 3, null, null, "Priya Nair", "PN", null, 31, "Toast dry spices in a dry pan for 30 to 60 seconds before using them. This blooming releases essential oils and dramatically deepens the flavor. Works for cumin, coriander, paprika — any whole or ground spice. A 1-minute step that makes a massive difference.", null, new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 203, null, null, null, null, "Spices & Seasoning", "🌶️", "Always Bloom Your Spices First", 2, null, null, null },
                    { 4, "https://images.unsplash.com/photo-1567620905732-2d1ec7ab7445?w=700", null, "Elena Cruz", "EC", "Breakfast", 9, "Made this for the whole family last weekend and it was gone in minutes. The trick is day-old brioche — it soaks up the custard without getting soggy. I add cream cheese and strawberry jam in the middle. Game changer for brunch!", 45, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Easy", "1 loaf day-old brioche, cubed\n4 large eggs\n1.5 cups milk\n1/2 cup heavy cream\n3 tbsp maple syrup\n1 tsp vanilla extract\n200g cream cheese\n3 tbsp strawberry jam\nPowdered sugar for serving", 56, "https://images.unsplash.com/photo-1484723091739-30a097e8f929?w=700", 10, 6, "Grease a 9x13 baking dish. Place half the brioche cubes inside.\nMix cream cheese and jam; dollop over the bread layer.\nTop with remaining brioche cubes.\nWhisk eggs, milk, cream, maple syrup, and vanilla. Pour over bread.\nPress down gently; cover and refrigerate overnight or 1 hour.\nBake at 175C for 40-45 minutes until golden and puffed.\nDust with powdered sugar and serve with extra maple syrup.", null, null, "Sunday Morning French Toast Bake", 0, null, null, null },
                    { 5, null, null, "Chef Antoine", "CA", null, 47, "There is nothing more satisfying than making pasta with your own hands. I walk through everything: flour ratio, kneading, resting time, and rolling. No pasta machine needed — just a rolling pin and patience.", null, new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 289, null, null, null, null, null, null, "Homemade Pasta from Scratch — Full Process", 1, "12:07", "https://www.youtube.com/embed/dQw4w9WgXcQ", "https://images.unsplash.com/photo-1556909114-f6e7ad7d3136?w=700" },
                    { 6, null, null, "Sarah Kim", "SK", null, 19, "When making pie crust, biscuits, or scones, your butter must be ice cold. Warm butter melts into the flour and creates a dense texture. Cold butter creates steam pockets while baking, resulting in light, flaky layers. Cut into cubes and freeze 15 minutes before using.", null, new DateTime(2026, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 178, null, null, null, null, "Baking", "🧈", "Use Cold Butter for Flakier Pastry", 2, null, null, null }
                });
        }
    }
}
