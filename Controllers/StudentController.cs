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
            return View();
        }
    }
}
