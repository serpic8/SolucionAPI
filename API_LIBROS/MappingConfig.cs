using API_LIBROS.Models;
using API_LIBROS.Models.Dto;
using AutoMapper;

namespace API_LIBROS
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Libros, LibrosDto>();
            CreateMap<LibrosDto, Libros>();

            CreateMap<Libros, LibrosCreateDto>().ReverseMap();
            CreateMap<Libros, LibrosUpdateDto>().ReverseMap();

        }

    }
}
