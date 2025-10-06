using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsersMicroservices.Domain.Entities;

namespace UsersMicroservices.Infrastructure.Configurations;

public class UserProfileConfiguration: BaseEntityConfiguration<UserProfile>
{
    public override void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        base.Configure(builder);
        
        builder.ToTable("UsersProfile");
        
        builder.HasIndex(x => x.FullName);
        
        builder.Property(profile => profile.FirstName).HasColumnName("FirstName").HasMaxLength(10).IsRequired();
        
        builder.Property(profile => profile.SecondName).HasColumnName("SecondName").HasMaxLength(10).IsRequired();
        
        builder.Property(profile => profile.LastName).HasColumnName("LastName").HasMaxLength(10).IsRequired();
        
        builder.Property(profile => profile.Bio).HasColumnName("Biography").HasMaxLength(600).IsRequired();
        
        builder.Property(profile => profile.ProfileImageUrl).HasColumnName("ProfileImage").IsRequired();
    }
}