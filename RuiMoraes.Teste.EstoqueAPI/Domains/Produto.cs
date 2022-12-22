using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;

namespace RuiMoraes.Teste.EstoqueAPI.Domains
{
    public class Produto : BaseEntidade
    {
        public Produto()
        {

        }

        public Produto(int id, string nome, string descricao, decimal preco, int quantidade, int categoriaid, EnumSituacao situacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Quantidade = quantidade;
            CategoriaId = categoriaid;
            Situacao = situacao;

        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
