using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntidade
    {
        IEnumerable<TEntity> BuscaTodos();
        TEntity BuscaPorId(int? id);
        TEntity Adicionar(TEntity entity);
        TEntity Editar(TEntity entity);
    }
}
