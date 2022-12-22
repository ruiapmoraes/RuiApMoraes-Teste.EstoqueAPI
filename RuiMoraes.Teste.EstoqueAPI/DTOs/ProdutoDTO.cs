using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;
using System.ComponentModel;
using System.Text.Json.Serialization;

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

        [DisplayName("Categorias")]
        public int CategoriaId { get; set; }
        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}
