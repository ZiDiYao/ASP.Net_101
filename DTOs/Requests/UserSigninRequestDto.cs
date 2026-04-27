using System.ComponentModel.DataAnnotations;

namespace WebApplicationC__Tut101.DTOs.Requests
{
    public class UserSigninRequestDto
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}