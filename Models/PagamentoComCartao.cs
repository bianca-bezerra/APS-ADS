using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class PagamentoComCartao : TipoPagamento
    {
        [Display(Name = "Número do Cartão")]
        public string? NumeroDoCartao {get;set;}
        public string? Bandeira {get; set;}
    }
}