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
            var category = new Category { Id = id.HasValue ? id.Value : 0 };
            return View(category);
        }
    }
}
