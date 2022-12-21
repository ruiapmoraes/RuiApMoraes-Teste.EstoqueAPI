using AutoMapper;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.DTOs;

namespace RuiMoraes.Teste.EstoqueAPI.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
