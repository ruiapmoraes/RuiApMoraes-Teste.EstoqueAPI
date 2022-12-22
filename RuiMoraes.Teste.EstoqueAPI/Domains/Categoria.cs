using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;

namespace RuiMoraes.Teste.EstoqueAPI.Domains
{
    public class Categoria : BaseEntidade
    {
        //public Categoria()
        //{

        //}

        //public Categoria(int id, string nome, string descricao, EnumSituacao situacao)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Descricao = descricao;
        //    Situacao = situacao;
        //    DataCriacao = DateTime.Now;
        //    Produtos = new List<Produto>();
        //}

        public string Nome { get; set; }
        public string Descricao { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
