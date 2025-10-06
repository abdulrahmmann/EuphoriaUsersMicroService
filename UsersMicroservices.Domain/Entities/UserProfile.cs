using UsersMicroservices.Domain.Bases;
using UsersMicroservices.Domain.ValueObjects;

namespace UsersMicroservices.Domain.Entities;

public class UserProfile: Entity<int>
{
    public string FullName { get; private set; } = null!;
    public string ProfileImageUrl { get; private set; } = null!;
    public string Bio { get; private set; } = null!;
    
    public Address Address { get; private set; } = null!;
    
    public int UserId  { get; set; }
    public ApplicationUser ApplicationUser { get; private set; } = null!;
}