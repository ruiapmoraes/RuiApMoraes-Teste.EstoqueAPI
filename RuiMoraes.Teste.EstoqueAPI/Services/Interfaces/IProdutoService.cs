using RuiMoraes.Teste.EstoqueAPI.DTOs;

namespace RuiMoraes.Teste.EstoqueAPI.Services.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoDTO> BuscarTodos();
        ProdutoDTO BuscarPorId(int? id);
        void Criar(ProdutoDTO produtoDTO);

        void Edtar(ProdutoDTO productDto);
    }
}
