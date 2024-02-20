using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Naxxum.JobyHunter.Authentication.Domain.Repositories;
using Naxxum.JobyHunter.Authentication.Infrastructure.Data;
using Naxxum.JobyHunter.Authentication.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naxxum.JobyHunter.Authentication.Infrastructure
{
    public static  class DependencyInjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructureServices
           (this IServiceCollection services, IConfiguration configuration)

        {
             services.AddDbContext<AppIdentityContext>(options =>
                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ??
                     throw new InvalidOperationException("connection string 'DefaultConnection not found '"))
             );

            // services.AddTransient<IRepository<...>,Repository>();
            return services;

        }
    }
}
