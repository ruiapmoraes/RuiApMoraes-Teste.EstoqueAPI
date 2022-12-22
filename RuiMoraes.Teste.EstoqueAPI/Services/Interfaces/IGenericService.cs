using RuiMoraes.Teste.EstoqueAPI.Data.Interfaces;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.DTOs;

namespace RuiMoraes.Teste.EstoqueAPI.Services.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : BaseEntidade
    {
        IEnumerable<TEntity> BuscarTodos();
        TEntity BuscarPorId(int? id);
        void Criae(TEntity categoryDto);
        void Editar(TEntity categoryDto);
      


    }
}
