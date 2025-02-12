using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.DTOs.UserDTOs
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        //This should be converted to hash before being sent to the database.
        public string Password { get; set; }
    }
}
