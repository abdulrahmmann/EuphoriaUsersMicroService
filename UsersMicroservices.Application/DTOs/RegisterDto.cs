using UsersMicroservices.Application.Enums;

namespace UsersMicroservices.Application.DTOs;

public record RegisterDto(string? Email, string? Password, string? Username, 
    string? PhoneNumber, GenderOption? GenderOption);