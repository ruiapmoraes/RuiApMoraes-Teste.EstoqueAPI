using RuiMoraes.Teste.EstoqueAPI.Data.Context;
using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntidade
    {
        protected readonly EstoqueAPIDbContext _context;

        public GenericRepository(EstoqueAPIDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity BuscaPorId(int? id)
        {
            var result = _context.Set<TEntity>().Find(id);
            return result;
        }

        public TEntity Adicionar(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Editar(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
