using laba3.Models.Roles;

namespace laba3.Models
{
    public class User
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public Role UserRole { get; set; } = new CommonUserRole();

        public User(
            string username,
            string email,
            string phoneNumber)
        {
            Username = username;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
