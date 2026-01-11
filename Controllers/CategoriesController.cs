using Microsoft.AspNetCore.Mvc;
using MVCCourse.Models;

namespace MVCCourse.Controllers
{
    public class CategoriesController : Controller
    {
        
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }
        public IActionResult Edit(int? id)
        {
            var category = CategoryRepository.GetCategoryById(id.HasValue?id.Value:0);
            return View(category);
        }

        [HttpPost]

        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                CategoryRepository.UpdateCategory(category.Id, category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
    }
}
