using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsersMicroservices.Domain.Entities;

namespace UsersMicroservices.Infrastructure.Configurations;

public class ApplicationUserConfiguration: BaseEntityConfiguration<ApplicationUser>
{
    public override void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        base.Configure(builder);

        builder.ToTable("Users");
        
        builder.HasIndex(x => x.Email).IsUnique();
        builder.HasIndex(x => x.PhoneNumber).IsUnique();
        builder.HasIndex(x => x.Gender).IsUnique();
        
        builder.Property(u => u.Email).HasMaxLength(100).HasColumnName("Email").IsRequired();
        
        builder.Property(u => u.Password).HasMaxLength(200).HasColumnName("Password").IsRequired();
        
        builder.Property(u => u.PhoneNumber).HasMaxLength(20).HasColumnName("PhoneNumber").IsRequired();
        
        builder.Property(u => u.Username).HasMaxLength(30).HasColumnName("Username").IsRequired();
        
        builder.Property(u => u.Gender).HasColumnName("Gender").IsRequired();
        
        builder
            .HasOne(user => user.UserProfile)
            .WithOne(profile => profile.ApplicationUser)
            .HasForeignKey<UserProfile>(profile => profile.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}