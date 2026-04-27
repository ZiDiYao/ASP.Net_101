using WebApplicationC__Tut101.Models;

namespace WebApplicationC__Tut101.Repositories.Interfaces
{
    public interface IUserRepository
    {
        // Get
        IEnumerable<User> GetAll();

        User? GetById(int id);

        User? GetByEmail(string email);

        // Add
        User Add(User user);

        // Edit
        bool Update(User user);

        // Delete
        bool Delete(User user);

        bool DeleteById(int id);
    }
}