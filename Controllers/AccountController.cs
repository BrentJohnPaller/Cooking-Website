using CookingWebsite.Data;
using CookingWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookingWebsite.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext db, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
            _env = env;
        }

        public IActionResult Register() => View();

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var user = new AppUser
            {
                UserName = vm.Email,
                Email = vm.Email,
                DisplayName = vm.DisplayName,
                JoinedDate = DateTime.Now
            };

            var result = await _userManager.CreateAsync(user, vm.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            return View(vm);
        }

        public IActionResult Login(string? returnUrl = null)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel vm, string? returnUrl = null)
        {
            if (!ModelState.IsValid) return View(vm);

            var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);
            if (result.Succeeded)
                return LocalRedirect(returnUrl ?? "/");

            ModelState.AddModelError("", "Invalid email or password.");
            return View(vm);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var posts = await _db.Posts
                .Where(p => p.Author == user.DisplayName)
                .OrderByDescending(p => p.DatePosted)
                .ToListAsync();

            ViewBag.Posts = posts;
            return View(user);
        }

        [Authorize]
        public async Task<IActionResult> EditProfile()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var vm = new EditProfileViewModel
            {
                DisplayName = user.DisplayName,
                Bio = user.Bio,
                CurrentPhotoUrl = user.ProfilePhotoUrl
            };
            return View(vm);
        }

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(EditProfileViewModel vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            if (vm.ProfilePhoto != null && vm.ProfilePhoto.Length > 0)
            {
                var uploadFolder = Path.Combine(_env.WebRootPath, "uploads", "profiles");
                Directory.CreateDirectory(uploadFolder);

                var ext = Path.GetExtension(vm.ProfilePhoto.FileName).ToLowerInvariant();
                var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp", ".gif" };
                if (allowed.Contains(ext))
                {
                    if (!string.IsNullOrEmpty(user.ProfilePhotoUrl))
                    {
                        var oldPath = Path.Combine(_env.WebRootPath, user.ProfilePhotoUrl.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
                        if (System.IO.File.Exists(oldPath)) System.IO.File.Delete(oldPath);
                    }

                    var fileName = Guid.NewGuid().ToString() + ext;
                    var fullPath = Path.Combine(uploadFolder, fileName);
                    using var stream = new FileStream(fullPath, FileMode.Create);
                    await vm.ProfilePhoto.CopyToAsync(stream);
                    user.ProfilePhotoUrl = "/uploads/profiles/" + fileName;
                }
            }

            user.DisplayName = vm.DisplayName.Trim();
            user.Bio = vm.Bio?.Trim();
            await _userManager.UpdateAsync(user);

            TempData["Success"] = "Profile updated successfully!";
            return RedirectToAction(nameof(Profile));
        }

        [Authorize]
        public IActionResult ChangePassword() => View();

        [Authorize, HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return RedirectToAction("Login");

            var result = await _userManager.ChangePasswordAsync(user, vm.CurrentPassword, vm.NewPassword);
            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                TempData["Success"] = "Password changed successfully!";
                return RedirectToAction(nameof(Profile));
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError("", error.Description);

            return View(vm);
        }
    }
}