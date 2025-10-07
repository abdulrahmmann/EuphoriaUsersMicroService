using MapsterMapper;
using UsersMicroservices.Application.DTOs;
using UsersMicroservices.Application.UsersFeature.Query;
using UsersMicroservices.Domain.CQRS;
using UsersMicroservices.Domain.IRepository;

namespace UsersMicroservices.Application.UsersFeature.QueryHandler;

public class GetUserByIdQueryHandler: IQueryHandler<GetUserByIdQuery, AuthenticationResponse>
{
    #region Field Instance
    private readonly IUserRepository _repository;
    private readonly IMapper  _mapper;
    #endregion

    #region MyRegion
    public GetUserByIdQueryHandler(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    #endregion
    
    public async Task<AuthenticationResponse> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var usersRepository = await _repository.GetUserById(request.UserId);

            var usersMap = _mapper.Map<AuthenticationResponse>(usersRepository);

            return usersMap;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}