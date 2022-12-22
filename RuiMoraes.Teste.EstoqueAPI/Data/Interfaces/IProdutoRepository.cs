using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Interfaces
{
    public interface IProdutoRepository : IGenericRepository<Produto>
    {
        IEnumerable<Produto> BuscarProdutos();
        Produto BuscarProdutoPorId(int? id);
    }
}
