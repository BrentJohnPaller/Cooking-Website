using Microsoft.AspNetCore.Mvc;
using CookingWebsite.Services;

namespace CookingWebsite.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            var recipes = RecipeService.GetAllRecipes();
            ViewBag.Categories = RecipeService.GetCategories();
            return View(recipes);
        }

        public IActionResult Details(int id)
        {
            var recipe = RecipeService.GetRecipeById(id);
            if (recipe == null) return NotFound();

            var allRecipes = RecipeService.GetAllRecipes();
            ViewBag.RelatedRecipes = allRecipes
                .Where(r => r.Category == recipe.Category && r.Id != id)
                .Take(3).ToList();

            return View(recipe);
        }
    }
}