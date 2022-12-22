using RuiMoraes.Teste.EstoqueAPI.Data.Context;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(EstoqueAPIDbContext context) : base(context)
        {
        }
    }
}
