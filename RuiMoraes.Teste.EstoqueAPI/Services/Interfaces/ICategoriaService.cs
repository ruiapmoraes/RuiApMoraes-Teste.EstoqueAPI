using RuiMoraes.Teste.EstoqueAPI.DTOs;

namespace RuiMoraes.Teste.EstoqueAPI.Services.Interfaces
{
    public interface ICategoriaService
    {
        IEnumerable<CategoriaDTO> BuscarTodos();
        CategoriaDTO BuscarPorId(int? id);
        void Criar(CategoriaDTO categoriaDto);
        void Editar(CategoriaDTO categoriaDto);
    }
}
