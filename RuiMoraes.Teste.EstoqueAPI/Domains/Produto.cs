namespace RuiMoraes.Teste.EstoqueAPI.Domains
{
    public class Produto : BaseEntidade
    {
        public Produto()
        {

        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
