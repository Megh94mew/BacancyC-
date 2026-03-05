using TMS.Models;

namespace TMS.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User> getByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task SaveAsync();
    }
}