namespace E_TutorApplicationFront.Models.ViewModel
{
    public class StudentWishListViewModel
    {
        public int Id { get; set; }
        public string? ImgPath { get; set; }
        public List<InstructorsList>? Instructors { get; set; }
        public double StarPoint { get; set; }
        public decimal Price { get; set; }
        public string? CourseName { get; set; }
    }

    public class InstructorsList
    {
        public int Id { get; set; }
        public string? InstructorFullName { get; set; }
    }
}
