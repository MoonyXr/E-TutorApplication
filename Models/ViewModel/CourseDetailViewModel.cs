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
        public int RatingCount { get; set; }
        public List<int>? CourseRatings { get; set; }
        public CourseRatingScore Score { get; set; }
        public CourseDetailedInformation? CourseDetailedInfo { get; set; }

    }

    public class CourseCreators
    {
        public int InstructorId { get; set; }
        public string InstructorImagUrl { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
    }

    public class CourseDetailedInformation
    {
        public int LectureCount { get; set; }
        public double LectureSize { get; set; }
        public int TotalComments { get; set; }
        public int StudentsEnrolled { get; set; }
        public string CourseLevel { get; set; }
        public string CourseLanguage { get; set; }
        public int AtachFile { get; set; }
        public double AtachFileSize { get; set; }
        public string Hours { get; set; }
        public int StudentsViewed { get; set; }

    }

    public class CourseRatingScore
    {
        public int Percentage5Star { get; set; }
        public int Percentage4Star { get; set; }
        public int Percentage3Star { get; set; }
        public int Percentage2Star { get; set; }
        public int Percentage1Star { get; set; }
    }
}
