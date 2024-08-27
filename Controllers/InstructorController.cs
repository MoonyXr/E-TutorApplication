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
            return View();
        }

        public void DeleteCourse(int courseId)
        {

        }

    }
}
