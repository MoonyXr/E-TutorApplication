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

        public IActionResult StudentWishList()
        {
            var model = new List<StudentWishListViewModel>()
            {
                new StudentWishListViewModel {Id = 1, ImgPath= "/images/studentcourseimages/courseimg46.svg", CourseName = "The Ultimate Drawing Course - Beginner to Advanced", Price = 37, StarPoint = 4.6,  Instructors = new List<InstructorsList>(){ new InstructorsList { InstructorFullName = "Harry Potter" },new InstructorsList { InstructorFullName = "John Wick" },  } }, 
                new StudentWishListViewModel {Id = 2, ImgPath= "/images/studentcourseimages/courseimg48.svg", CourseName = "Digital Marketing Masterclass - 23 Courses in 1", Price = 24, StarPoint = 4.8,  Instructors = new List<InstructorsList>(){ new InstructorsList { InstructorFullName = "Nobody" } } }, 
                new StudentWishListViewModel {Id = 3, ImgPath= "/images/studentcourseimages/courseimg47.svg", CourseName = "Angular - The Complete Guide (2021 Edition)", Price = 13, StarPoint = 4.7,  Instructors = new List<InstructorsList>(){ new InstructorsList { InstructorFullName = "Nobody" } } }
            }; 

            return View(model); 
        }

        public IActionResult StudentSettings()
        {
            
            var model = new StudentBioInformation()
            {
                Name = "Moony",
                Surname = "Xristo",
                Email = "Moony@gmail.com",
                Username = "moon1234",
                UpdatePasswordViewModel = null
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ChangeStudentPassword(UpdatePasswordViewModel updateStudentPassword)
        {
            if (!ModelState.IsValid)
                return View("StudentSettings", updateStudentPassword);
            return RedirectToAction("StudentSettings");
        }

        [HttpPost]
        public IActionResult ChangeStudentBioInformation(StudentBioInformation studentBioInformation)
        {
            
            return View();
        }


    }
}
