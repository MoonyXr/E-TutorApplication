using E_TutorApplicationFront.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace E_TutorApplicationFront.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentDashboard() 
        {
            StudentDashboardCardsViewModel model = new StudentDashboardCardsViewModel()
            {
                EnrolledCoursesCount = 957,
                ActiveCoursesCount = 6,
                COmplitedCoursesCount = 951,
                CourseInstructorCount = 241
            };

            return View(model);
        }

        public IActionResult StudentCourses()
        {
            return View();
        }
    }
}
