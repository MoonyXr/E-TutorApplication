using E_TutorApplicationFront.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_TutorApplicationFront.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string selectedCategory = null)
        {
            List<Category> list = new List<Category>()
            {
                new Category{Id = 1 , Name = "Development", ImgUrl = ""},
                new Category{Id = 2 , Name = "Business", ImgUrl = ""},
                new Category{Id = 3 , Name = "Finance & Accounting", ImgUrl = ""},
                new Category{Id = 4 , Name = "IT & Software", ImgUrl = ""}
            };
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Filter categories based on the selected category if needed
                list = list.Where(c => c.Name == selectedCategory).ToList();
            }

            return View(list); 
        }
    }
}
