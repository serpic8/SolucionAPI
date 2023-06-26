using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_LIBROS.Models
{
    public class Libros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_AUTOR { get; set; }

        public string TITULO { get; set; }

        public double PRECIO { get; set; }

        public string CATEGORIA { get; set; }

        public int EXISTENCIA { get; set; }



    }
}
