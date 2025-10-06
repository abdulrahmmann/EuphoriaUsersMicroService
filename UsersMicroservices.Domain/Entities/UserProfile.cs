using UsersMicroservices.Domain.Bases;
using UsersMicroservices.Domain.ValueObjects;

namespace UsersMicroservices.Domain.Entities;

/// <summary>
/// Represents a user's profile containing personal and extended information.
/// </summary>
public class UserProfile : Entity<int>
{
    /// <summary>
    /// The user's first name.
    /// </summary>
    public string FirstName { get; private set; } = null!;

    /// <summary>
    /// The user's middle or second name (optional).
    /// </summary>
    public string? SecondName { get; private set; } 

    /// <summary>
    /// The user's last name or family name.
    /// </summary>
    public string LastName { get; private set; } = null!;

    /// <summary>
    /// The user's full name, automatically combined from first, second, and last names.
    /// </summary>
    public string FullName => $"{FirstName} {SecondName} {LastName}".Trim();

    /// <summary>
    /// URL of the user's profile image or avatar (optional).
    /// </summary>
    public string? ProfileImageUrl { get; private set; }

    /// <summary>
    /// A short biography or personal description written by the user.
    /// </summary>
    public string Bio { get; private set; } = null!;

    /// <summary>
    /// The user's address information as a value object.
    /// </summary>
    public Address Address { get; private set; } = null!;

    /// <summary>
    /// The foreign key referencing the associated application user.
    /// </summary>
    public int UserId { get; private set; }

    /// <summary>
    /// Navigation property for the related <see cref="ApplicationUser"/>.
    /// </summary>
    public ApplicationUser ApplicationUser { get; private set; } = null!;
}
