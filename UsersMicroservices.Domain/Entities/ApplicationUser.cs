using UsersMicroservices.Domain.Bases;

namespace UsersMicroservices.Domain.Entities;

/// <summary>
/// Represents an application user with basic authentication and Info.
/// </summary>
public class ApplicationUser : Entity<int>
{
    /// <summary>
    /// The user's unique email address used for login and communication.
    /// </summary>
    public string Email { get; private set; } = null!;

    /// <summary>
    /// The user's password (hashed and secured before storage).
    /// </summary>
    public string Password { get; private set; } = null!;

    /// <summary>
    /// The user's phone number, used for verification or contact purposes.
    /// </summary>
    public string PhoneNumber { get; private set; } = null!;

    /// <summary>
    /// The username chosen by the user, used for display and identification.
    /// </summary>
    public string Username { get; private set; } = null!;

    /// <summary>
    /// The user's gender. Allowed values: "Male" or "Female"; we are not supporting gays people.
    /// </summary>
    public string Gender { get; private set; } = null!;

    /// <summary>
    /// Navigation property that references the user's extended profile information.
    /// </summary>
    public UserProfile UserProfile { get; private set; } = null!;
}