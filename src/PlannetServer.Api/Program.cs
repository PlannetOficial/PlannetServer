using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlannetServer.Application;
using PlannetServer.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la aplicación
var configuration = builder.Configuration;
builder.Services.AddControllers();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

// Configuración del pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
    app.UseHttpsRedirection();
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    c.RoutePrefix = string.Empty; // Para servir Swagger en la raíz (opcional)
});

app.UseRouting();

app.UseAuthorization();

app.UseInfrastructure();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello Mario, the princess is in another castle!");
    });
    endpoints.MapControllers();
});

app.Run();
