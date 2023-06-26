using API_LIBROS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_LIBROS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Libros> libros => Set<Libros>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libros>().HasData(
                new Libros() 
                { 
                    ID_AUTOR = 1,
                    TITULO = "Camino Hacia el Dorado",
                    PRECIO = 700.00,
                    CATEGORIA = "Filosofia",
                    EXISTENCIA = 9

                },
                new Libros()
                {
                    ID_AUTOR = 2,
                    TITULO = "EL Alquimista",
                    PRECIO = 800.00,
                    CATEGORIA = "Historia",
                    EXISTENCIA = 4

                },
                new Libros()
                {
                    ID_AUTOR = 3,
                    TITULO = "Viaje al Fin del Mundo",
                    PRECIO = 700.00,
                    CATEGORIA = "Aventura",
                    EXISTENCIA = 10

                },
                new Libros()
                {
                    ID_AUTOR = 4,
                    TITULO = "Superman:Legacy",
                    PRECIO = 700.00,
                    CATEGORIA = "Slice of Life",
                    EXISTENCIA = 1

                },
                new Libros()
                {
                    ID_AUTOR = 5,
                    TITULO = "Coraline",
                    PRECIO = 10000,
                    CATEGORIA = "Fantasia Oscura",
                    EXISTENCIA = 9

                },
                new Libros()
                {
                    ID_AUTOR = 6,
                    TITULO = "Superman:Legacy",
                    PRECIO = 700.00,
                    CATEGORIA = "Slice of Life",
                    EXISTENCIA = 1

                });        
        }
    }
}
