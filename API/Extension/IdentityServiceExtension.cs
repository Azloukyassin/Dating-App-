using API.Interfaces;
using API.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extension
{
    public static class IdentityServiceExtension
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services , IConfiguration config)
        {
          //services.AddAuthentication(Jwtb)

        }
    }
}