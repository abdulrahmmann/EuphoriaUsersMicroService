using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UsersMicroservices.Infrastructure.Context;

namespace UsersMicroservices.Infrastructure;

public static class ModuleDependencyInjection
{
    public static IServiceCollection AddInfrastructureDependency(this IServiceCollection services, IConfiguration configuration)
    {
        // Register Db Context
        var connectionStringTemplate = configuration.GetConnectionString("PostgresConnection")!;
        
        var connectionString = connectionStringTemplate
            .Replace("$POSTGRES_HOST", "POSTGRES_HOST")
            .Replace("$POSTGRES_PORT", "POSTGRES_PORT")
            .Replace("$POSTGRES_DB", "POSTGRES_DB")
            .Replace("$POSTGRES_USERNAME", "POSTGRES_USERNAME")
            .Replace("$POSTGRES_PASSWORD", "POSTGRES_PASSWORD");
            
        
        // Register Repository
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
        
        
        return services;
    }
}