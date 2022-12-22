using AutoMapper;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.DTOs;
using RuiMoraes.Teste.EstoqueAPI.Services.Interfaces;

namespace RuiMoraes.Teste.EstoqueAPI.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public IEnumerable<CategoriaDTO> BuscarTodos()
        {
            var categoriaEntities = _categoriaRepository.BuscaTodos();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriaEntities);

        }
        public CategoriaDTO BuscarPorId(int? id)
        {
            var categoriaEntity = _categoriaRepository.BuscaPorId(id);
            return _mapper.Map<CategoriaDTO>(categoriaEntity);  
        }


        public void Criar(CategoriaDTO categoriaDto)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDto);
            _categoriaRepository.Adicionar(categoriaEntity);
            categoriaDto.Id = categoriaEntity.Id;

        }

        public void Editar(CategoriaDTO categoriaDto)
        {
            var categoriaEntity = _mapper.Map<Categoria>(categoriaDto);
            _categoriaRepository.Editar(categoriaEntity);
        }
    }
}
