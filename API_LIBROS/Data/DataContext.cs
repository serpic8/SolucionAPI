﻿using API_LIBROS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_LIBROS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Libros> libros => Set<Libros>();
        public DbSet<User> user => Set<User>();

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

                },
                new Libros()
                {
                    ID_AUTOR = 7,
                    TITULO = "Green Lantern:Legacy",
                    PRECIO = 700.00,
                    CATEGORIA = "Action",
                    EXISTENCIA = 20

                },
                new Libros()
                {
                    ID_AUTOR = 8,
                    TITULO = "Flash-Point",
                    PRECIO = 700.00,
                    CATEGORIA = "Action",
                    EXISTENCIA = 5

                });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "admin",
                    Password = "123.",
                    Role = "Admin"
                },
                new User()
                {
                    Id = 2,
                    Name = "usuario",
                    Password = "123.",
                    Role = "Public"
                }
            );
        }
    }
}
