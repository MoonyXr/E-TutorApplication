using E_TutorApplicationFront.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing.Printing;

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
        public IActionResult StudentCourses(int page = 1, int pageSize = 12)
        {
            var courses = new List<StudentCoursesViewModel>()
            {
                new StudentCoursesViewModel() {CourseId =1, CourseName = "Learn More About Web Design", CourseImgUrl = "", CourseSectionName = "Learn Ethical Hacking From Scratch", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =2, CourseName = "Font Properties Challenge 3", CourseImgUrl = "", CourseSectionName = "SQL for NEWBS: Weekender Crash Course", CourseWatchPercentage = 2, IsStart = true},
                new StudentCoursesViewModel() {CourseId =3, CourseName = "Adding Content to Our Website", CourseImgUrl = "", CourseSectionName = "Complete Adobe Lightroom Megacourse: Begin...", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =4, CourseName = "CSS Font Property Challenge Solution", CourseImgUrl = "", CourseSectionName = "Machine Learning A-Z™: Hands-On Python & R I...", CourseWatchPercentage = 23, IsStart = true},
                new StudentCoursesViewModel() {CourseId =5, CourseName = "Adding Content to Our Website", CourseImgUrl = "", CourseSectionName = "Premiere Pro CC for Beginners: Video Editing in...", CourseWatchPercentage = 26, IsStart = true},
                new StudentCoursesViewModel() {CourseId =6, CourseName = "The Dark Art of Centering Elements w...", CourseImgUrl = "", CourseSectionName = "Graphic Design Masterclass - Learn GREAT De...", CourseWatchPercentage = 21, IsStart = true},
                new StudentCoursesViewModel() {CourseId =7, CourseName = "CSS Static and Relative Positioning", CourseImgUrl = "", CourseSectionName = "Angular - The Complete Guide (2021 Edition)", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =8, CourseName = "Learn More About Typography", CourseImgUrl = "", CourseSectionName = "Complete Blender Creator: Learn 3D Modelling...", CourseWatchPercentage = 52, IsStart = true},
                new StudentCoursesViewModel() {CourseId =1, CourseName = "Learn More About Web Design", CourseImgUrl = "", CourseSectionName = "Learn Ethical Hacking From Scratch", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =2, CourseName = "Font Properties Challenge 3", CourseImgUrl = "", CourseSectionName = "SQL for NEWBS: Weekender Crash Course", CourseWatchPercentage = 2, IsStart = true},
                new StudentCoursesViewModel() {CourseId =3, CourseName = "Adding Content to Our Website", CourseImgUrl = "", CourseSectionName = "Complete Adobe Lightroom Megacourse: Begin...", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =4, CourseName = "CSS Font Property Challenge Solution", CourseImgUrl = "", CourseSectionName = "Machine Learning A-Z™: Hands-On Python & R I...", CourseWatchPercentage = 23, IsStart = true},
                new StudentCoursesViewModel() {CourseId =5, CourseName = "Adding Content to Our Website", CourseImgUrl = "", CourseSectionName = "Premiere Pro CC for Beginners: Video Editing in...", CourseWatchPercentage = 26, IsStart = true},
                new StudentCoursesViewModel() {CourseId =6, CourseName = "The Dark Art of Centering Elements w...", CourseImgUrl = "", CourseSectionName = "Graphic Design Masterclass - Learn GREAT De...", CourseWatchPercentage = 21, IsStart = true},
                new StudentCoursesViewModel() {CourseId =7, CourseName = "CSS Static and Relative Positioning", CourseImgUrl = "", CourseSectionName = "Angular - The Complete Guide (2021 Edition)", CourseWatchPercentage = 0, IsStart = false},
                new StudentCoursesViewModel() {CourseId =8, CourseName = "Learn More About Typography", CourseImgUrl = "", CourseSectionName = "Complete Blender Creator: Learn 3D Modelling...", CourseWatchPercentage = 52, IsStart = true},
                new StudentCoursesViewModel() {CourseId =9, CourseName = "Introductions", CourseImgUrl = "", CourseSectionName = "Ultimate Google Ads Training 2020: Profit with...", CourseWatchPercentage = 0, IsStart = false},
            };
            var pagedCourses = courses.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = Math.Ceiling((double)courses.Count() / pageSize);
            ViewBag.CurrentPage = page;

            return View(pagedCourses);
        }
        public IActionResult StudentTeachers(int page = 1, int pageSize = 12)
        {
            var teachers = new List<StudentTeachersViewModel>()
            {
                new StudentTeachersViewModel(){Id = 1,TeacherFullname = "Wade Warren", StudentsCount = 20, TeacherPoint = 5.0, TeacherSpecialty = "Digital Product Designer"},
                new StudentTeachersViewModel(){Id = 2,TeacherFullname = "Bessie Cooper", StudentsCount = 568, TeacherPoint = 4.5, TeacherSpecialty = "Senior Developer"},
                new StudentTeachersViewModel(){Id = 3,TeacherFullname = "Floyd Miles", StudentsCount = 568, TeacherPoint = 4.5, TeacherSpecialty = "UI/UX Designer"},
                new StudentTeachersViewModel(){Id = 4,TeacherFullname = "Ronald Richards", StudentsCount = 435, TeacherPoint = 5, TeacherSpecialty = "Lead Developer"},
                new StudentTeachersViewModel(){Id = 5,TeacherFullname = "Devon Lane", StudentsCount = 435, TeacherPoint = 4.0, TeacherSpecialty = "Senior Developer"},
                new StudentTeachersViewModel(){Id = 6,TeacherFullname = "Robert Fox", StudentsCount = 356, TeacherPoint = 4.5, TeacherSpecialty = "UI/UX Designer"},
                new StudentTeachersViewModel(){Id = 7,TeacherFullname = "Kathryn Murphy", StudentsCount = 356, TeacherPoint = 5.0, TeacherSpecialty = "Adobe Instructor"},
                new StudentTeachersViewModel(){Id = 8,TeacherFullname = "Jerome Bell", StudentsCount = 711, TeacherPoint = 5.0, TeacherSpecialty = "Adobe Instructor"},
            };
            var pagedTeachers = teachers.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.TotalPages = Math.Ceiling((double)teachers.Count() / pageSize);
            ViewBag.CurrentPage = page;

            return View(pagedTeachers);
        }

    }
}
