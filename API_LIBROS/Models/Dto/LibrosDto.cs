﻿namespace API_LIBROS.Models.Dto
{
    public class LibrosDto
    {
        public int ID_AUTOR { get; set; }

        public string TITULO { get; set; }

        public double PRECIO { get; set; }

        public string CATEGORIA { get; set; }

        public int EXISTENCIA { get; set; }
    }
}