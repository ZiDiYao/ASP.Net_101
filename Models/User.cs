using WebApplicationC__Tut101.Models.Enums;
namespace WebApplicationC__Tut101.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; } = string.Empty;

        public int Age { get; set; }

        public RolesEnums Role { get; set; } = RolesEnums.User;

        public bool IsActive { get; set; } = true;

        public string PasswordHash { get; private set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }


        public void setPasswordHash(string passwordHash)
        {
            // Are responsible for hashing the password and setting the PasswordHash property
        }
    }
}
