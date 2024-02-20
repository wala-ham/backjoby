using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Naxxum.JobyHunter.Authentication.Infrastructure.Enums;

namespace Naxxum.JobyHunter.Authentication.Infrastructure.Seeds
{
    public class DefaultRoles
    {
        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
          // await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
          //  await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

        }

    }
}
