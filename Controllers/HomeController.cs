using E_TutorApplicationFront.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using E_TutorApplicationFront.Models;
using E_TutorApplicationFront.ViewComponents;

namespace E_TutorApplicationFront.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Categories(int page = 1, int pageSize = 20)
        {
            var courses = new List<CoursesViewModel>()
            {
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.2 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.3 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =4.5 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
                new CoursesViewModel{ CourseName = "Learn Python Programming Masterclass", CategoryName = "IT & Software", Rating =5.0 , StudentCount = "211,434", Price = 40, Url = "/images/CourseImages.svg"},
            };
                
            var pagedCourses = courses.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = Math.Ceiling((double)courses.Count() / pageSize);
            ViewBag.CurrentPage = page;

            return View(pagedCourses);
        }

    }
}
