namespace UsersMicroservices.Application.DTOs;

public record UserDto(
    int? UserId,
    string? Email,
    string? PhoneNumber,
    string? Username,
    string? Gender,
    string? Token,
    bool Success)
{
    public UserDto(): this(default, default, default, default, default, default, default)
    {
        
    }
}