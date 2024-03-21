using Application.Profiles;
using Application.Services;
using Application.Services.Interfaces;
using Application.Validators;
using AutoMapper;
using Domain.Models;
using FluentValidation;
using Infra.Persistence;
using Microsoft.Extensions.DependencyInjection;
namespace Application.Configuration;

public static class DependencyInjectionConfig
{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            /* Mapper */
            services.AddAutoMapper(typeof(ClienteProfile), typeof(EnderecoProfile));
            /* Mapper */

            
            /* Cliente */
            services.AddScoped<AbstractValidator<Cliente>>(provider =>
            {
                var dbContext = provider.GetRequiredService<SeradDbContext>();
                return new ClienteValidator(dbContext);
            });
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<AbstractValidator<Endereco>, EnderecoValidator>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            /* Cliente */

            

            return services;
        }
}