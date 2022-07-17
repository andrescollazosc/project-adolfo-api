using SlnRestaurant.Core.Services.Contracts;
using SlnRestaurant.Core.Services.Entities;
using SlnRestaurant.Infrastructure.Data.Repositories;

namespace SlnRestaurant.Api.WebApi.IoC;

public static class DependencyBuilder
{
    public static void CofigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",
                builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
        });
    }

    public static void DependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IGenericRepository<Order>, OrderRepository>();
        services.AddScoped<IGenericRepository<Table>, TableRepository>();
    }

}
