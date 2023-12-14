using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class Pagamento
    {
        public int Id {get; set;}
        [Display(Name = "Data de Vencimento")]
        public DateTime DataLimite {get; set;}
        public double Valor {get; set;}
        public bool Pago {get; set;}
        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}