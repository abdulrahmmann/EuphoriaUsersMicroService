using MapsterMapper;
using UsersMicroservices.Application.DTOs;
using UsersMicroservices.Application.UsersFeature.Query;
using UsersMicroservices.Domain.CQRS;
using UsersMicroservices.Domain.IRepository;

namespace UsersMicroservices.Application.UsersFeature.QueryHandler;

public class GetUsersQueryHandle: IQueryHandler<GetUsersQuery, IEnumerable<AuthenticationResponse>>
{
    #region Field Instance
    private readonly IUserRepository _repository;
    private readonly IMapper  _mapper;
    #endregion

    #region MyRegion
    public GetUsersQueryHandle(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    #endregion

    public async Task<IEnumerable<AuthenticationResponse>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var usersRepository = await _repository.GetUsers();

            var usersMap = _mapper.Map<IEnumerable<AuthenticationResponse>>(usersRepository);

            return usersMap;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}