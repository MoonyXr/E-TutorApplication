namespace E_TutorApplicationFront.Models.ViewModel
{
    public class CourseDetailViewModel
    {
        public int CourseId { get; set; }
        public string CourseImgURL { get; set; }
        public DateTime UploadedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CourseCreators> Creators { get; set; }
        public double CourseRating { get; set; }
        public double CoursePrice { get; set; }
        public double CourseRevenue { get; set; }
    }

    public class CourseCreators
    {
        public int InstructorId { get; set; }
        public string InstructorImagUrl { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
    }
}
