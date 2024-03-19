using Application.Services;
using Application.Services.Interfaces;
using Application.Validators;
using Domain.Models;
using FluentValidation;
using Infra.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Infra.Configuration;
namespace Application.Configuration;

public static class DependencyInjectionConfig
{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            /* Cliente */
            services.AddScoped<AbstractValidator<Cliente>>(provider =>
            {
                var dbContext = provider.GetRequiredService<SeradDbContext>();
                return new ClienteValidator(dbContext);
            });
            services.AddScoped<IClienteService, ClienteService>();
            /* Cliente */

            return services;
        }
}