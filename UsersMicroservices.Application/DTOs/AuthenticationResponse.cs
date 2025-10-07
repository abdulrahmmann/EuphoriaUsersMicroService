namespace UsersMicroservices.Application.DTOs;

public record AuthenticationResponse(
    int? UserId,
    string? Email,
    string? PhoneNumber,
    string? Username,
    string? Gender,
    string? Token,
    bool Success)
{
    public AuthenticationResponse(): this(default, default, default, default, default, default, default)
    {
        
    }
}