using UsersMicroservices.Domain.Bases;
using UsersMicroservices.Domain.ValueObjects;

namespace UsersMicroservices.Domain.Entities;

public class UserProfile : Entity<int>
{
    public string FirstName { get; private set; } = null!;
    public string SecondName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public string FullName => $"{FirstName} {SecondName} {LastName}".Trim();

    public string ProfileImageUrl { get; private set; } = null!;
    public string Bio { get; private set; } = null!;

    public Address Address { get; private set; } = null!;

    // Foreign Key
    public int UserId { get; private set; }
    public ApplicationUser ApplicationUser { get; private set; } = null!;
}