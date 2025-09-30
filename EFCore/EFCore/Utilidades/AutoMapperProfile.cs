using AutoMapper;
using EFCore.DTOs;
using EFCore.Entidades;

namespace EFCore.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<GeneroCreacion, Genero>();
            CreateMap<ActorCreacionDTO, Actor>();
            CreateMap<PeliculasCreacionDTO, Pelicula>();
        }
    }
}
