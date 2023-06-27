using API_LIBROS.Models;

namespace API_LIBROS.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUser (string username, string pass);

        Task<User> GetUser(string username, string pass); 
    }
}
