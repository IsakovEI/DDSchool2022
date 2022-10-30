using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class CreateUserModel
    {
        [Required]
        public string Name { get; set; } = "empty";
        [Required]
        public string Email { get; set; } = "empty";
        [Required]
        public string Password { get; set; } = "empty";
        [Required]
        [Compare(nameof(Password))]
        public string RetryPassword { get; set; } = "empty";
        [Required]
        public DateTimeOffset BirtDate { get; set; }

        public CreateUserModel(string name, string email, string password, string retryPassword, DateTimeOffset birtDate)
        {
            Name = name;
            Email = email;
            Password = password;
            RetryPassword = retryPassword;
            BirtDate = birtDate;
        }
    }
}
