namespace bianca.Models
{
    public class PagamentoComCartao : TipoPagamento
    {
        public string? NumeroDoCartao {get;set;}
        public string? Bandeira {get; set;}
    }
}