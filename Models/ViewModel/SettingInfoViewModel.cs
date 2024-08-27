using System.ComponentModel.DataAnnotations;

namespace E_TutorApplicationFront.Models.ViewModel
{
    public class SettingInfoViewModel
    {
        public int InstructorId { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(20, ErrorMessage = "Username cannot exceed 20 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Phone prefix is required.")]
        [Range(1, 999, ErrorMessage = "Phone prefix must be between 1 and 999.")]
        public int PhonePrefix { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Range(1000000, 9999999, ErrorMessage = "Phone number must be a 7-digit number.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Tittle { get; set; }

        [StringLength(1000, ErrorMessage = "Biography cannot exceed 1000 characters.")]
        public string Biography { get; set; }

        public string  ProfileImageUrl { get; set; }
    }
}
