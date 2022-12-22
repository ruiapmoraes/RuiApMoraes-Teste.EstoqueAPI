using Microsoft.EntityFrameworkCore;
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


        public IEnumerable<Produto> BuscarProdutos()
        {
            var produtos = _context.Produtos.Include(c => c.Categoria).ToList();
            return produtos;
        }
        public Produto BuscarProdutoPorId(int? id)
        {
            return _context.Produtos.Include(c => c.Categoria).SingleOrDefault(p => p.Id == id);            
        }
    }
}
