using E_TutorApplicationFront.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace E_TutorApplicationFront.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Category> list = new List<Category>()
            {
                new Category{Id = 1 , CategoryName = "Development", ImgUrl = ""},
                new Category{Id = 2 , CategoryName = "Business", ImgUrl = ""},
                new Category{Id = 3 , CategoryName = "Finance & Accounting", ImgUrl = ""},
                new Category{Id = 4 , CategoryName = "IT & Software", ImgUrl = ""}
            };

            return View("~/Views/Shared/Components/Category/Default.cshtml", list); 
        }
    }
}
