using E_TutorApplicationFront.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
namespace E_TutorApplicationFront.ViewComponents
{
    public class StudentCoursesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<StudentCoursesViewModel> courselist = new List<StudentCoursesViewModel>()
            {
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "1. Intorductions" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "1. Intorductions" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "1. Intorductions" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "1. Intorductions" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "1. Intorductions" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
                new StudentCoursesViewModel {CourseId = 1, CourseName = "Reiki Level I, II and Master/Teacher Program", CourseSectionName = "2. Students" , CourseWatchPercentage = 0, CourseImgUrl = "/images/CourseImages.svg"},
            };

            return View(courselist);
        }
    }
}
