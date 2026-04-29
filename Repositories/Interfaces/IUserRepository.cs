using WebApplicationC__Tut101.Models;

namespace WebApplicationC__Tut101.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string userName);

        Task<User?> GetByEmailAsync(string email);

        Task AddAsync(User user);

        Task<bool> ExistsByUserNameAsync(string userName);

        Task<bool> ExistsByEmailAsync(string email);
    }
}