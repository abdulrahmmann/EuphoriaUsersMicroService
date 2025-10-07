using Microsoft.EntityFrameworkCore;
using UsersMicroservices.Domain.Entities;
using UsersMicroservices.Domain.IRepository;
using UsersMicroservices.Infrastructure.Context;

namespace UsersMicroservices.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<ApplicationUser>> GetUsers()
    {
        return await _dbContext.ApplicationUser.ToListAsync();
    }

    public async Task<ApplicationUser> GetUserById(int? id)
    {
        return await _dbContext.ApplicationUser.FirstOrDefaultAsync(u => u.Id == id) ??
               throw new InvalidOperationException();
    }

    public async Task<ApplicationUser> GetUserByEmail(string? email)
    {
        return await _dbContext.ApplicationUser.FirstOrDefaultAsync(u => u.Email == email) ??
               throw new InvalidOperationException();
    }

    public async Task<IEnumerable<ApplicationUser>> GetUsersByGender(string? gender)
    {
        return await _dbContext.ApplicationUser.Where(u => u.Gender == gender).ToListAsync();
    }
}