using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_LIBROS.Models
{
    public class Autores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_AUTOR { get; set; }

        public string AUTOR { get; set; }
    }
}
