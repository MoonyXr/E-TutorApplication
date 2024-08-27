namespace E_TutorApplicationFront.Models.ViewModel
{
    public class InstructorSettingsNotificationViewModel
    {
        public int InstructorId { get; set; }
        public bool WhoBuyMyCourse { get; set; }
        public bool WhoWriteReviews { get; set; }
        public bool WhoCommentedMyLecture { get; set; }
        public bool WhoDownloadMyLecture { get; set; }
        public bool WhoRepliedMyComment { get; set; }
        public bool HowManyPeopleVisit { get; set; }
        public bool WhoDownloadAttachFile { get; set; }
    }
}
