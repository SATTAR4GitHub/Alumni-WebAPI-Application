using AlumniAPI.Data;
using AlumniAPI.Interfaces;
using AlumniAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AlumniAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
       public static IServiceCollection AddAppicationServices(this IServiceCollection services, IConfiguration config) 
       {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
       }
    }
}