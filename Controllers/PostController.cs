using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CookingWebsite.Models;
using CookingWebsite.Data;

namespace CookingWebsite.Controllers
{
    public class PostController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;

        public PostController(AppDbContext db, IWebHostEnvironment env, UserManager<AppUser> userManager)
        {
            _db = db;
            _env = env;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _db.Posts.OrderByDescending(p => p.DatePosted).ToListAsync();

            var authorNames = posts.Select(p => p.Author).Distinct().ToList();
            var authorPhotos = await _db.Users
                .Where(u => authorNames.Contains(u.DisplayName))
                .ToDictionaryAsync(u => u.DisplayName, u => u.ProfilePhotoUrl);
            ViewBag.AuthorPhotos = authorPhotos;

            return View(posts);
        }

        public async Task<IActionResult> Details(int id)
        {
            var post = await _db.Posts.FindAsync(id);
            if (post == null) return NotFound();

            var comments = await _db.Comments
                .Include(c => c.User)
                .Include(c => c.Replies).ThenInclude(r => r.User)
                .Include(c => c.CommentLikes)
                .Where(c => c.PostId == id && c.ParentCommentId == null)
                .OrderByDescending(c => c.DatePosted)
                .ToListAsync();

            ViewBag.Comments = comments;
            ViewBag.Related = await _db.Posts
                .Where(p => p.Type == post.Type && p.Id != id)
                .OrderByDescending(p => p.DatePosted)
                .Take(3)
                .ToListAsync();

            var userId = _userManager.GetUserId(User);
            ViewBag.UserLikedPost = userId != null && await _db.PostLikes.AnyAsync(pl => pl.PostId == id && pl.UserId == userId);
            ViewBag.UserLikedComments = userId != null
                ? await _db.CommentLikes.Where(cl => cl.UserId == userId).Select(cl => cl.CommentId).ToListAsync()
                : new List<int>();

            var postAuthor = await _db.Users.FirstOrDefaultAsync(u => u.DisplayName == post.Author);
            ViewBag.AuthorPhotoUrl = postAuthor?.ProfilePhotoUrl;

            return View(post);
        }

        [Authorize]
        public IActionResult Create(string? type)
        {
            var vm = new CreatePostViewModel();
            if (Enum.TryParse<PostType>(type, out var parsed))
                vm.Type = parsed;
            return View(vm);
        }

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreatePostViewModel vm)
        {
            if (string.IsNullOrWhiteSpace(vm.Title) || string.IsNullOrWhiteSpace(vm.Content))
            {
                ModelState.AddModelError("", "Title and description are required.");
                return View(vm);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var uploadFolder = Path.Combine(_env.WebRootPath, "uploads");
            Directory.CreateDirectory(uploadFolder);

            async Task<string?> SavePhoto(IFormFile? file)
            {
                if (file == null || file.Length == 0) return null;
                var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp", ".gif" };
                if (!allowed.Contains(ext)) return null;
                var fileName = Guid.NewGuid().ToString() + ext;
                var fullPath = Path.Combine(uploadFolder, fileName);
                using var stream = new FileStream(fullPath, FileMode.Create);
                await file.CopyToAsync(stream);
                return "/uploads/" + fileName;
            }

            var photo1 = await SavePhoto(vm.Photo1);
            var photo2 = await SavePhoto(vm.Photo2);
            var photo3 = await SavePhoto(vm.Photo3);

            var post = new Post
            {
                Title = vm.Title.Trim(),
                Content = vm.Content.Trim(),
                Type = vm.Type,
                Author = user.DisplayName,
                AuthorAvatar = string.Concat(user.DisplayName.Split(' ').Take(2).Select(w => char.ToUpper(w[0]).ToString())),
                DatePosted = DateTime.Now,
                Likes = 0,
                Comments = 0,
                PhotoUrl = photo1,
                AdditionalPhoto2 = photo2,
                AdditionalPhoto3 = photo3,
                Category = vm.Category?.Trim(),
                Difficulty = vm.Difficulty,
                CookTimeMinutes = vm.CookTimeMinutes,
                PrepTimeMinutes = vm.PrepTimeMinutes,
                Servings = vm.Servings,
                Ingredients = vm.Ingredients?.Trim(),
                Steps = vm.Steps?.Trim(),
                VideoEmbedUrl = GetYoutubeEmbedUrl(vm.VideoEmbedUrl?.Trim()),
                VideoThumbnail = GetYoutubeThumbnail(vm.VideoEmbedUrl?.Trim()),
                VideoDuration = "0:00",
                TipIcon = vm.TipIcon?.Trim(),
                TipCategory = vm.TipCategory?.Trim()
            };

            _db.Posts.Add(post);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Your post has been shared!";
            return RedirectToAction(nameof(Details), new { id = post.Id });
        }

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            var post = await _db.Posts.FindAsync(id);
            if (post != null && user != null && post.Author == user.DisplayName)
            {
                void DeletePhoto(string? url)
                {
                    if (string.IsNullOrEmpty(url) || !url.StartsWith("/uploads/")) return;
                    var path = Path.Combine(_env.WebRootPath, url.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
                    if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
                }
                DeletePhoto(post.PhotoUrl);
                DeletePhoto(post.AdditionalPhoto2);
                DeletePhoto(post.AdditionalPhoto3);
                _db.Posts.Remove(post);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [Authorize, HttpPost]
        public async Task<IActionResult> ToggleLike(int id)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Json(new { success = false });

            var existing = await _db.PostLikes.FirstOrDefaultAsync(pl => pl.PostId == id && pl.UserId == userId);
            var post = await _db.Posts.FindAsync(id);
            if (post == null) return Json(new { success = false });

            bool liked;
            if (existing != null)
            {
                _db.PostLikes.Remove(existing);
                post.Likes = Math.Max(0, post.Likes - 1);
                liked = false;
            }
            else
            {
                _db.PostLikes.Add(new PostLike { PostId = id, UserId = userId });
                post.Likes++;
                liked = true;
            }

            await _db.SaveChangesAsync();
            return Json(new { success = true, likes = post.Likes, liked });
        }

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment(int postId, string content, int? parentCommentId = null)
        {
            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction(nameof(Details), new { id = postId });

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login", "Account");

            var comment = new Comment
            {
                PostId = postId,
                Content = content.Trim(),
                UserId = user.Id,
                ParentCommentId = parentCommentId,
                DatePosted = DateTime.Now
            };

            _db.Comments.Add(comment);

            var post = await _db.Posts.FindAsync(postId);
            if (post != null) post.Comments++;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Details), new { id = postId });
        }

        [Authorize, HttpPost]
        public async Task<IActionResult> ToggleCommentLike(int id)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Json(new { success = false });

            var comment = await _db.Comments.FindAsync(id);
            if (comment == null) return Json(new { success = false });

            var existing = await _db.CommentLikes.FirstOrDefaultAsync(cl => cl.CommentId == id && cl.UserId == userId);

            bool liked;
            if (existing != null)
            {
                _db.CommentLikes.Remove(existing);
                comment.Likes = Math.Max(0, comment.Likes - 1);
                liked = false;
            }
            else
            {
                _db.CommentLikes.Add(new CommentLike { CommentId = id, UserId = userId });
                comment.Likes++;
                liked = true;
            }

            await _db.SaveChangesAsync();
            return Json(new { success = true, likes = comment.Likes, liked });
        }

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteComment(int commentId, int postId)
        {
            var user = await _userManager.GetUserAsync(User);
            var comment = await _db.Comments.FindAsync(commentId);

            if (comment != null && user != null && comment.UserId == user.Id)
            {
                _db.Comments.Remove(comment);
                var post = await _db.Posts.FindAsync(postId);
                if (post != null) post.Comments = Math.Max(0, post.Comments - 1);
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Details), new { id = postId });
        }

        private static string? ExtractYoutubeId(string? url)
        {
            if (string.IsNullOrEmpty(url)) return null;
            try
            {
                var uri = new Uri(url);
                if (uri.Host.Contains("youtu.be"))
                    return uri.AbsolutePath.TrimStart('/').Split('?')[0];
                if (uri.AbsolutePath.StartsWith("/embed/"))
                    return uri.AbsolutePath.Replace("/embed/", "").Split('?')[0];
                if (uri.AbsolutePath.StartsWith("/shorts/"))
                    return uri.AbsolutePath.Replace("/shorts/", "").Split('?')[0];
                var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
                return query["v"];
            }
            catch { return null; }
        }

        private static string? GetYoutubeThumbnail(string? url)
        {
            var id = ExtractYoutubeId(url);
            return string.IsNullOrEmpty(id) ? null : $"https://img.youtube.com/vi/{id}/hqdefault.jpg";
        }

        private static string? GetYoutubeEmbedUrl(string? url)
        {
            var id = ExtractYoutubeId(url);
            return string.IsNullOrEmpty(id) ? null : $"https://www.youtube.com/embed/{id}";
        }
    }
}