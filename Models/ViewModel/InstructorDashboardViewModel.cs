namespace E_TutorApplicationFront.Models.ViewModel
{
    public class InstructorDashboardViewModel
    {
        public int InstructorId { get; set; }
        
        public List<AsStudentViewModel>   AsStudentViews { get; set; }
        public List<AsInstructorViewModel>   asInstructorViews { get; set; }
        }

    public class AsStudentViewModel
    {
        public int EnrolledCourses { get; set; }
        public int ActiveCourses { get; set; }
        public int CourseInstructors { get; set; }
        public int ComplitedCourses { get; set; }
    }

    public class AsInstructorViewModel
    {
        public int Students { get; set; }
        public int OnlineCourses { get; set; }
        public int TotalEarnings { get; set; }
        public int CourseSold { get; set; }
    }
}
