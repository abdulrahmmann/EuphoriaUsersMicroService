using UsersMicroservices.Domain.Bases;

namespace UsersMicroservices.Domain.Entities;

public class ApplicationUser: Entity<int>
{
    public string Email { get; private set; } = null!;
    public string Password { get; private set; } = null!;
    public string PhoneNumber { get; private set; } = null!;
    
    public string Username { get; private set; } = null!;
    public string Gender { get; private set; } = null!;
    
    public int UserProfileId { get; private set; }
    public UserProfile UserProfile { get; private set; } = null!;
}