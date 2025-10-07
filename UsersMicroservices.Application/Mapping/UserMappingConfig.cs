using Mapster;
using UsersMicroservices.Application.DTOs;
using UsersMicroservices.Domain.Entities;

namespace UsersMicroservices.Application.Mapping;

public class UserMappingConfig: IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<ApplicationUser, AuthenticationResponse>()
            .Map(dest => dest.UserId, src => src.Id)
            .Map(dest => dest.Email, src => src.Email)
            .Map(dest => dest.PhoneNumber, src => src.PhoneNumber)
            .Map(dest => dest.Username, src => src.Username)
            .Map(dest => dest.Gender, src => src.Gender)
            .Ignore(dest => dest.Token!)
            .Ignore(dest => dest.Success!);


    }
}