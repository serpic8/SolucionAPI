using API_LIBROS.Data;
using API_LIBROS.Models;
using API_LIBROS.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API_LIBROS.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _db;

        public UserRepository(DataContext db)
        {
            _db = db;
        }

        public bool IsUser(string username, string pass)
        {
            var users = _db.user.ToList();
            return users.Where(u => u.Name == username && u.Password == pass).Count() > 0;
        }

        public async Task<User> GetUser(string username, string pass)
        {
            return await _db.user.FirstOrDefaultAsync(u => u.Name == username &&
            u.Password == pass);
        }
    }
}
