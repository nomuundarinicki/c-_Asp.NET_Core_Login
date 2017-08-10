using System.ComponentModel.DataAnnotations;

namespace login.Models 
{
    public abstract class BaseEntity {}
    public class User : BaseEntity 
    {
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{2,45}$", ErrorMessage = "Numbers are not allowed in your first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{2,45}$", ErrorMessage = "Numbers are not allowed in your last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
    }
}
