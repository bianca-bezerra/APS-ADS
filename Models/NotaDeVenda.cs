namespace bianca.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        public DateTime Data {get; set;}
        public bool Tipo {get; set;}

        public virtual ICollection<Item>? Itens {get; set;}

        public int Cliente_Id {get;set;}
        public virtual Cliente? Cliente {get; set;}

        public int Vendedor_Id {get;set;}
        public virtual Vendedor? Vendedor {get; set;}

        public virtual Transportadora? Transportadora {get; set;}
        public int Transportadora_Id {get;set;}

        public virtual Pagamento? Pagamento {get; set;}
        public int Pagamento_Id {get;set;}

        public virtual ICollection<TipoPagamento>? TiposPagamento {get;set;}
    }
}