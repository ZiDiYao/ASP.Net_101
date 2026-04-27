using System.ComponentModel.DataAnnotations;

namespace WebApplicationC__Tut101.DTOs.Requests
{
    public class UserSignupRequestDto
    {
        [Required]
        public string Username { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Age { get; set; }

        // 密码通常需要前端传明文，然后后端去 Hash
        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}