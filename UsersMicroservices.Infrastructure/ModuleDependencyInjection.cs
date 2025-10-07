using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsersMicroservices.Domain.IRepository;
using UsersMicroservices.Infrastructure.Context;
using UsersMicroservices.Infrastructure.Repository;

namespace UsersMicroservices.Infrastructure;

public static class ModuleDependencyInjection
{
    public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services, IConfiguration configuration)
    {
        // Register Db Context
        var connectionStringTemplate = configuration.GetConnectionString("PostgresConnection")!;

        var connectionString = connectionStringTemplate
            .Replace("$POSTGRES_HOST", Environment.GetEnvironmentVariable("POSTGRES_HOST") ?? "postgres")
            .Replace("$POSTGRES_PORT", Environment.GetEnvironmentVariable("POSTGRES_PORT") ?? "5432")
            .Replace("$POSTGRES_DB", Environment.GetEnvironmentVariable("POSTGRES_DB") ?? "EuphoriaUsers")
            .Replace("$POSTGRES_USERNAME", Environment.GetEnvironmentVariable("POSTGRES_USERNAME") ?? "postgres")
            .Replace("$POSTGRES_PASSWORD", Environment.GetEnvironmentVariable("POSTGRES_PASSWORD") ?? "admin");
            
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        
        // Register Repository
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}