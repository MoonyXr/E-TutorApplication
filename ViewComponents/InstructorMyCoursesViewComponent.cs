using Microsoft.AspNetCore.Mvc;
using E_TutorApplicationFront.Models.Entities;
using E_TutorApplicationFront.Models.ViewModel;

namespace E_TutorApplicationFront.ViewComponents
{
    public class InstructorMyCoursesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int page = 1, int pageSize = 12)
        {

            List<CoursesViewModel> coursesList = new List<CoursesViewModel>()
            {
                   new CoursesViewModel{CourseId = 1, CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 2, CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 3,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 4,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 5,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 6,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 7,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 8,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 9,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 10,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 11,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 12,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 13,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 14,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 15,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 16,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 17,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 18,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 19,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 20,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 21, CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.2 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 22,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.3 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 23,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.5 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{CourseId = 24,  CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =5.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
            };
            var paginatedCourses = coursesList.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)coursesList.Count / pageSize);

            return View(paginatedCourses);
        }
    }
}
