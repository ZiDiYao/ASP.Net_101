using Microsoft.EntityFrameworkCore;
using WebApplicationC__Tut101.Data;
using WebApplicationC__Tut101.Models;
using WebApplicationC__Tut101.Repositories.Interfaces;

namespace WebApplicationC__Tut101.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetByUserNameAsync(string userName)
        {
            throw new NotImplementedException();
        }
    }

}