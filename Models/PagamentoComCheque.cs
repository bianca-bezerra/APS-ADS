namespace bianca.Models
{
    public class PagamentoComCheque : TipoPagamento
    {
        public int Banco {get; set;}
        public string? NomeDoBanco {get; set;}
    }
}