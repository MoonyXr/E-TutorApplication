namespace E_TutorApplicationFront.Models.ViewModel
{
    public class StudentBioInformation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Title { get; set; }
        public string? ImgPath { get; set; }

        public UpdatePasswordViewModel? UpdatePasswordViewModel { get; set; }
    }
}
