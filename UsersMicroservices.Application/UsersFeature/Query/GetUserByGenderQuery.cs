using UsersMicroservices.Application.DTOs;
using UsersMicroservices.Domain.CQRS;

namespace UsersMicroservices.Application.UsersFeature.Query;

public record GetUserByGenderQuery(): IQuery<IEnumerable<AuthenticationResponse>>;