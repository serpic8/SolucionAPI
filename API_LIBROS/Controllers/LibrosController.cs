using API_LIBROS.Models.Dto;
using API_LIBROS.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API_LIBROS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LibrosController : ControllerBase
    {
        private readonly ILogger<LibrosController> _logger;
        private readonly ILibrosRepository _librosRepo;
        private readonly IMapper _mapper;

        public LibrosController(ILogger<LibrosController> logger, ILibrosRepository librosRepo, IMapper mapper)
        {
            _logger = logger;
            _librosRepo = librosRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<LibrosDto>>> GetProducts()
        {
            _logger.LogInformation("Obtener los libros");
            var librosList = await _librosRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<LibrosDto>>(librosList));
        }


    }
}
