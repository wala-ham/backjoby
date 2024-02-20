using System.ComponentModel.DataAnnotations;

namespace Naxxum.JobyHunter.Authentication.Application.User.DTOS.Account
{
    public class AssignRolesDto
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}