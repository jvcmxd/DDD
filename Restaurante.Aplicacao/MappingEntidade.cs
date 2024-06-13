
using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Restaurante.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Prato, PratoDTO>();
            CreateMap<PratoDTO, Prato>();
        }
    }
}