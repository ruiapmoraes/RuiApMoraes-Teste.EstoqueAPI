using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;
using System.ComponentModel;

namespace RuiMoraes.Teste.EstoqueAPI.DTOs
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime? DataCriacao { get; set; }
        public EnumSituacao Situacao { get; set; }

        public int CategoriaId { get; set; }

        [DisplayName("Categorias")]
        public Categoria Categoria { get; set; }
    }
}
