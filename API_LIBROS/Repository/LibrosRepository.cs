using API_LIBROS.Data;
using API_LIBROS.Models;
using API_LIBROS.Repository.IRepository;

namespace API_LIBROS.Repository
{
    public class LibrosRepository : Repository<Libros>, ILibrosRepository
    {
        private readonly DataContext _db;

        public LibrosRepository(DataContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Libros> AddLibros(Libros entity)
        {
            await _db.libros.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Libros> Update(Libros entity)
        {
            _db.libros.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<Libros> GetById(int id)
        {
            return await _db.libros.FindAsync(id);
        }

        public async Task Delete(Libros entity)
        {
            _db.libros.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
