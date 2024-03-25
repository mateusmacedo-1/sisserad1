using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Configuration;

public static class DependencyInjectionConfig
{
        public static IServiceCollection AddInfraServices(this IServiceCollection services, IConfiguration configuration)
        {
            var con = Environment.GetEnvironmentVariable("ConnectionString");
            if (con == null) {
                throw new Exception("ConnectionString não encontrada");
            }
            services.AddDbContext<SeradDbContext>(options =>
{
                options.UseNpgsql(con);
            });
            return services;
        }
}