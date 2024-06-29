using EMS.Application.Interface.Repository;
using EMS.Application.Interface.Service;
using EMS.Application.Services;
using EMS.Persistence.Context;
using EMS.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EMS.IOC
{
    public static class ServiceCollection
    {       
        
            public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString));
                return services;

            }

            public static IServiceCollection AddServices(this IServiceCollection services)
            {
                services.AddScoped<IEmployeeService, EmployeeService>();
                return services;
            }

            public static IServiceCollection AddRepositories(this IServiceCollection services)
            {
                services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                return services;
            }
    }
}