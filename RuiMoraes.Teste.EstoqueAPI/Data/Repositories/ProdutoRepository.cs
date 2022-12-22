using RuiMoraes.Teste.EstoqueAPI.Data.Context;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Repositories
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EstoqueAPIDbContext context) : base(context)
        {
        }
    }
}
