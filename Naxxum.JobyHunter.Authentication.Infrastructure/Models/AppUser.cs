using Microsoft.AspNetCore.Identity;
using Naxxum.JobyHunter.Authentication.Application.User.DTOS.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public List<RefreshToken>? RefreshTokens { get; set; }
    }
}
