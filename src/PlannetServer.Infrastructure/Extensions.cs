using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlannetServer.Application.Interfaces;
using PlannetServer.Core.Repositories;
using PlannetServer.Infrastructure.Data;
using PlannetServer.Infrastructure.Repositories;
using PlannetServer.Shared;
using PlannetServer.Shared.Contexts;
using PlannetServer.Shared.Exceptions;
using PlannetServer.Shared.Swagger;
using Microsoft.EntityFrameworkCore;

namespace PlannetServer.Infrastructure
{
    public static class Extensions
    {
        private const string CorrelationIdKey = "correlation-id";

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddErrorHandling();
            services.AddShared();
            services.AddContext();
            services.AddSwaggerDocs();
            services.AddMediatR(typeof(Extensions).Assembly, typeof(Application.Extensions).Assembly);

            // Configure the database context
            var connectionString = configuration.GetSection("sql:connectionString").Value;
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString, x => x.UseNetTopologySuite()));


            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IOrdersRepository, OrdersRepository>();
            services.AddTransient<IPostsRepository, PostsRepository>();

            return services;
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseCorrelationId();
            app.UseErrorHandling();
            app.UseSwaggerDocs();
            app.UseHttpsRedirection();
            app.UseContext();
            app.UseRouting();
            app.UseAuthorization();

            return app;
        }
    }
}
