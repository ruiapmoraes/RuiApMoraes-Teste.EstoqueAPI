using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;

namespace RuiMoraes.Teste.EstoqueAPI.Domains
{
    public abstract class BaseEntidade
    {
        public int Id { get; set; }
        public DateTime? DataCriacao { get; set; }
        public EnumSituacao Situacao { get; set; }
    }
}
