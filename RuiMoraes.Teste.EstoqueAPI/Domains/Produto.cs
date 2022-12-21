namespace RuiMoraes.Teste.EstoqueAPI.Domains
{
    public class Produto : BaseEntidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
