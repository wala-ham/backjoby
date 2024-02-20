using System.ComponentModel.DataAnnotations;

namespace Naxxum.JobyHunter.Authentication.Application.User.DTOS.Account
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}