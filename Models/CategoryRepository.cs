using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MVCCourse.Models
{
    public static class CategoryRepository
    {
        public static List<Category> _categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Beverage", Description = "Bevarage" },
            new Category { Id = 2, Name = "Bakery", Description = "Bakery" },
            new Category { Id = 3, Name = "Meat", Description = "Meat" }
        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.Id);
            category.Id = maxId + 1;
            _categories.Add(category);
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == Id);
            if (category != null)
            {
                return new Category
                {


                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                };
            }
            return null;
        }
        public static void UpdateCategory(int Id, Category category)
        {
            if (Id != category.Id) return;

            var categoryToUpdate = GetCategoryById(Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        public static void DeleteCategory(int Id)
        {
            var category = _categories.FirstOrDefault(x => x.Id == Id);
            if (category != null)
            {
                _categories.Remove(category);
            }

        }
    }
};
