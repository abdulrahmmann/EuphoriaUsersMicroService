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
            .Replace("$POSTGRES_HOST", "POSTGRES_HOST")
            .Replace("$POSTGRES_PORT", "POSTGRES_PORT")
            .Replace("$POSTGRES_DB", "POSTGRES_DB")
            .Replace("$POSTGRES_USERNAME", "POSTGRES_USERNAME")
            .Replace("$POSTGRES_PASSWORD", "POSTGRES_PASSWORD");
            
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        
        // Register Repository
        services.AddScoped<IUserRepository, UserRepository>();
        
        return services;
    }
}