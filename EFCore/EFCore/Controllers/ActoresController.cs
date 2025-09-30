using AutoMapper;
using EFCore.DTOs;
using EFCore.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCore.Controllers
{
    [ApiController]
    [Route("api/actores")]
    public class ActoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ActoresController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult> create(ActorCreacionDTO actorCreacionDTO)
        {
            var actor = _mapper.Map<Actor>(actorCreacionDTO);
            _context.Add(actor);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetByName(string nombre)
        {
            return await _context.Actores.Where(a => a.Nombre == nombre).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetAll()
        {
            return await _context.Actores.ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetByNameContains(string nombre)
        {
            return await _context.Actores.Where(a => a.Nombre.Contains(nombre)).ToListAsync();
        }
    }
}
