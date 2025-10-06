using Microsoft.EntityFrameworkCore;
using UsersMicroservices.Domain.Entities;

namespace UsersMicroservices.Infrastructure.Context;

public class ApplicationDbContext: DbContext
{
    public DbSet<ApplicationUser> ApplicationUser { get; set; }
    public DbSet<UserProfile> UserProfile { get; set; }
    
    protected ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}