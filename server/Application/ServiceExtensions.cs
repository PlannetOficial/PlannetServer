using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyReference>();
            services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>());
        }
    }
}
