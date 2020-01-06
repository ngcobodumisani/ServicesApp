using System.ComponentModel.DataAnnotations;

namespace LeaveApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Your must specify password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}