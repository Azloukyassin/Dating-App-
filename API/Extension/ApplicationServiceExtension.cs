using API.Interfaces;
using API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection service , IConfiguration config)
        {
            service.AddScoped<ITokenService , TokenService>(); 
            service.AddDbContext<DataContext>(options =>
             {
               options.UseSqlite(config.GetConnectionString("DefaultConnection"));
             });
             return service; 
        }
    }
}