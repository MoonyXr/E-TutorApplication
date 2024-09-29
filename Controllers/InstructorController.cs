using Microsoft.AspNetCore.Mvc;
using E_TutorApplicationFront.Models.ViewModel;
namespace E_TutorApplicationFront.Controllers
{
    public class InstructorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
           // List<AsStudentViewModel> asStudentViewModel = new List<AsStudentViewModel>()
           // {
           //     new AsStudentViewModel { ActiveCourses = }
           // };
           //InstructorDashboardViewModel viewModel = new InstructorDashboardViewModel()
           //{
           //     AsStudentViews = 
           //};
            return View();
        }

        public IActionResult BasicInformationCreateCourse()
        {
            ViewBag.PageName = "Create a new course";
            return View();
        }

        public IActionResult AdvancedInformation()
        {
            ViewBag.PageName = "Create a new course";
            return View();
        }

        public IActionResult Settings()
        {
            SettingsViewModel settingsViewModel = new SettingsViewModel();

            SettingInfoViewModel viewModel = new SettingInfoViewModel()
            {
                FirstName = "shahla"
            };

            SosialProfile sosialProfile = new SosialProfile();

            InstructorSettingsNotificationViewModel notificationViewModel = new InstructorSettingsNotificationViewModel()
            {
                HowManyPeopleVisit = true,
                WhoBuyMyCourse = true,
            };

            settingsViewModel.SettingInfo = viewModel;
            settingsViewModel.SosialProfile = sosialProfile;
            settingsViewModel.NotificationViewModel = notificationViewModel;
            List<int> prefix = new List<int>()
            {
                994, 1, 10, 20, 40
            };

            ViewBag.Prefix = prefix;
            return View(settingsViewModel);
        }


        [HttpPost]
        public IActionResult SettingsInformationUpdate(SettingInfoViewModel settingInfoViewModel)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Settings");
            return RedirectToAction("Settings");
        }

        [HttpPost]
        public IActionResult SosialProfileUpdate(SosialProfile sosialProfile)
        {
            return RedirectToAction("Settings");
        }
    
        [HttpPost]
        public IActionResult NotificationSettingsUpdate(InstructorSettingsNotificationViewModel notificationSettingsNotificationViewModel)
        {
            return RedirectToAction("Settings");
        } 

        [HttpPost]
        public IActionResult UpdatePassword(UpdatePasswordInstructorViewModel updatePasswordInstructor)
        {
            if(!ModelState.IsValid)
                return RedirectToAction("Settings");
            return RedirectToAction("Settings");
        }

        public IActionResult MyCourses()
        {
            return View();
        }

        public IActionResult InstructorMyCourses(int page = 1)
        {
            return ViewComponent("InstructorMyCourses", new { page = page });
        }

        
        public IActionResult ViewCourseDetail(int courseId)
        {
            CourseDetailViewModel viewModel = new CourseDetailViewModel()
            {
                CourseId = courseId,
                CourseImgURL = "/images/instructor/coursethumbnail.svg",
                Title= "2021 Complete Python Bootcamp From Zero to Hero in Python",
                Description = "3 in 1 Course: Learn to design websites with Figma, build with Webflow, and make a living freelancing.",
                UploadedDate = DateTime.Now.AddMonths(-3).Date,
                LastUpdateDate = DateTime.Now.Date,
                CoursePrice = 13.99,
                CourseRating = 3.4,
                CourseRevenue = 131800455.82,
                Creators = new List<CourseCreators>()
                {
                    new CourseCreators{InstructorId = 1, InstructorName = "Kevin" , InstructorSurname = "Gilbert", InstructorImagUrl = "/images/instructor/kevin.svg"},
                    new CourseCreators{InstructorId = 2, InstructorName = "Kristin" , InstructorSurname = "Watson", InstructorImagUrl = "/images/instructor/gilbert.svg"}
                },
                CourseDetailedInfo = new CourseDetailedInformation
                {
                    AtachFile = 142,
                    AtachFileSize = 14.4, 
                    CourseLevel = "Beginner",
                    LectureCount = 1957,
                    LectureSize = 219.3,
                    TotalComments = 429,
                    StudentsEnrolled = 2023,
                    CourseLanguage = "Mandarin",
                    Hours = "19:37:51",
                    StudentsViewed = 42919
                } ,
                CourseRatings = new List<int> 
                {
                    4, 4, 2, 4, 3, 4, 3, 4, 2, 4, 3, 4, 4, 3, 4, 2, 4, 3, 4
                },
                Score = new CourseRatingScore
                {
                    Percentage1Star = 0,
                    Percentage2Star = 1,
                    Percentage3Star = 5,
                    Percentage4Star = 27,
                    Percentage5Star = 67
                }

            };


            return View(viewModel);
        }

        public void DeleteCourse(int courseId)
        {

        }

    }
}
