using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Configuration;

public static class DependencyInjectionConfig
{
        public static IServiceCollection GetInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SeradDbContext>(options =>
{
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
}