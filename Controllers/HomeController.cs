using Microsoft.AspNetCore.Mvc;
using CookingWebsite.Services;

namespace CookingWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var recipes = RecipeService.GetAllRecipes();
            var tips = RecipeService.GetCookingTips();
            ViewBag.FeaturedRecipes = recipes.OrderByDescending(r => r.Likes).Take(3).ToList();
            ViewBag.LatestRecipes = recipes.OrderByDescending(r => r.DatePosted).Take(6).ToList();
            ViewBag.Tips = tips.Take(3).ToList();
            ViewBag.Categories = RecipeService.GetCategories();
            return View();
        }

        public IActionResult About() => View();
        public IActionResult Tips()
        {
            ViewBag.Tips = RecipeService.GetCookingTips();
            return View();
        }
    }
}
