using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Naxxum.JobyHunter.Authentication.Infrastructure.Models;


namespace Naxxum.JobyHunter.Authentication.Infrastructure.Data
{
   

    public class AppIdentityContext : IdentityDbContext<AppUser>
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options) : base(options)
        {
        }

       


    }


}
