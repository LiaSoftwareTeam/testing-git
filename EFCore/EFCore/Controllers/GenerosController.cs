using AutoMapper;
using EFCore.DTOs;
using EFCore.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Controllers
{
    [ApiController]
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GenerosController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(GeneroCreacion generoCreacion)
        {
            var genero = _mapper.Map<Genero>(generoCreacion);
            _context.Add(genero);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> GetAll()
        {
            return await _context.Generos.ToListAsync();
        }

        [HttpGet]
        public async Task<IEnumerable<Genero>> GetByGenero(string genero)
        {
            return await _context.Generos.Where(g => g.Nombre == genero).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genero>>> GetGeneroByContains(string genero)
        {
            return await _context.Generos.Where(g => g.Nombre.Contains(genero)).ToListAsync();
        }
    }

}
