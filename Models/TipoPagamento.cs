using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class TipoPagamento
    {
        public int Id {get; set;}
        [Display(Name = "Nome do Cobrado")]
        public string? NomeDoCobrado {get; set;}
        [Display(Name = "Informações Adicionais")]
        public string? InformacoesAdicionais {get; set;}
        [Display(Name = "Id da Nota de Venda")]
        public int NotaDeVenda_Id {get;set;}
        public virtual NotaDeVenda? NotaDeVenda {get;set;}
    }
}