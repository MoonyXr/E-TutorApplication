namespace E_TutorApplicationFront.Models.ViewModel
{
    public class StudentDashboardViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int EnrolledCoursesCount { get; set; }
        public int ActiveCoursesCount { get; set; }
        public int ComplitedCoursesCount { get; set; }
        public int CourseInstructorCount { get; set; }
     
    }
}
