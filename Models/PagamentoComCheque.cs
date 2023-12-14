using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class PagamentoComCheque : TipoPagamento
    {
        [Display(Name = "Nome do Banco")]
        public string? NomeDoBanco {get; set;}
        public int Banco {get; set;}
    }
}