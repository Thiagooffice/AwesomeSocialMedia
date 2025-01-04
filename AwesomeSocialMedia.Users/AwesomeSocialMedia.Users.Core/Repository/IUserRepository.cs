using AwesomeSocialMedia.Users.Core.Entities;

namespace AwesomeSocialMedia.Users.Core.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task<User?> GetByIdAsync(Guid id);
        Task<List<User>> GetAllAsync();
        Task DeleteAsync(User user);
    }
}