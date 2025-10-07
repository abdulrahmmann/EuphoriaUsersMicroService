using UsersMicroservices.Domain.Entities;

namespace UsersMicroservices.Domain.IRepository;

public interface IUserRepository
{
    Task<IEnumerable<ApplicationUser>> GetUsers();
    
    Task<ApplicationUser> GetUserById(int? id);
    
    Task<ApplicationUser> GetUserByEmail(string? email);

    Task<IEnumerable<ApplicationUser>> GetUsersByGender(string? gender); // Male || Female
}