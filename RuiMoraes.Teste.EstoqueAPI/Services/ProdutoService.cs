using AutoMapper;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Data.Repositories;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.DTOs;
using RuiMoraes.Teste.EstoqueAPI.Services.Interfaces;

namespace RuiMoraes.Teste.EstoqueAPI.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProdutoDTO> BuscarTodos()
        {
            var produtoEntities = _produtoRepository.BuscaTodos();
            return _mapper.Map<IEnumerable<ProdutoDTO>>(produtoEntities);
        }
        public ProdutoDTO BuscarPorId(int? id)
        {
            var produtoEntity = _produtoRepository.BuscaPorId(id);
            return _mapper.Map<ProdutoDTO>(produtoEntity);

        }

        public void Criar(ProdutoDTO produtoDTO)
        {
            var produtoEntity = _mapper.Map<Produto>(produtoDTO);
            _produtoRepository.Adicionar(produtoEntity);
            produtoDTO.Id = produtoEntity.Id;
        }

        public void Edtar(ProdutoDTO productDto)
        {
            var produtoEntity = _mapper.Map<Produto>(productDto);
            _produtoRepository.Editar(produtoEntity);
        }
    }
}
