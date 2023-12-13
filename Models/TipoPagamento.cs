namespace bianca.Models
{
    public class TipoPagamento
    {
        public int Id {get; set;}
        public string? NomeDoCobrado {get; set;}
        public string? InformacoesAdicionais {get; set;}

        public int NotaDeVenda_Id {get;set;}
        public virtual NotaDeVenda? NotaDeVenda {get;set;}
    }
}