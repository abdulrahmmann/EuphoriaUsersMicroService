using MediatR;
using UsersMicroservices.Application.UsersFeature.Query;

namespace UsersMicroservices.Endpoints;

public static class UserEndpoints
{
    public static void MapUserEndpoints(IEndpointRouteBuilder builder)
    {
        var endpoints = builder.MapGroup("/api/users")
            .WithTags("Users")
            .WithOpenApi();
        
        // Get User By Id
        endpoints.MapGet("/{id:int}", async (int id, IMediator mediator) =>
            {
                var query = new GetUserByIdQuery(id);
                var response = await mediator.Send(query);
                return response;
            })
            .WithName("GetBrandById")
            .WithSummary("Get brand by ID.")
            .WithDescription("Retrieves a single brand by its unique identifier.");
    }
}