using API_LIBROS.Models;

namespace API_LIBROS.Repository.IRepository
{
    public interface ILibrosRepository : IRepository<Libros>
    {
        Task SaveAsync();

        Task<Libros> Update(Libros entity);

        Task<Libros> AddLibros(Libros entity);

        Task<Libros> GetById(int id);

        Task Delete(Libros entity);
    }
}
