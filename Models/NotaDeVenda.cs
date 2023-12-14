using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        public DateTime Data {get; set;}
        public bool Tipo {get; set;}

        public virtual ICollection<Item>? Itens {get; set;}
        [Display(Name = "Id do Cliente")]

        public int Cliente_Id {get;set;}
        public virtual Cliente? Cliente {get; set;}
        public virtual Pagamento? Pagamento {get; set;}
        [Display(Name = "Id do Pagamento")]
        public int Pagamento_Id {get;set;}
        [Display(Name = "Id do Vendedor")]
        public int Vendedor_Id {get;set;}
        public virtual Vendedor? Vendedor {get; set;}
        [Display(Name = "Id da Transportadora")]
        public int Transportadora_Id {get;set;}
        public virtual ICollection<TipoPagamento>? TiposPagamento {get;set;}
         public virtual Transportadora? Transportadora {get; set;}
    }
}