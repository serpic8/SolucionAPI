using System.ComponentModel.DataAnnotations;

namespace API_LIBROS.Models
{
    public class User
    {
        [Key]
        public string? Name { get; set; }

        public string Password { get; set; }
    }
}
