using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;

namespace PlannetServer.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }

    }
}
