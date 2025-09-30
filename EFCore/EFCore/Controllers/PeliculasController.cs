using AutoMapper;
using EFCore.DTOs;
using EFCore.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Controllers
{
    [ApiController]
    [Route("api/peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PeliculasController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public Task<ActionResult> create(PeliculasCreacionDTO peliculasCreacionDTO)
        {
            var pelicula = _mapper.Map<Pelicula>(peliculasCreacionDTO);
            if (pelicula.Generos is not null)
            {
                foreach (var genero in pelicula.Generos)
                {
                    _context.Entry(genero).State = EntityState.Unchanged;
                }
            }
            
            if(pelicula.)
        }
    }
}
