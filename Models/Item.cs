namespace bianca.Models
{
    public class Item
    {
        public int Id {get; set;}
        public double Preco {get; set;}
        public int Percentual {get; set;}
        public int Quantidade {get; set;}

        public virtual ICollection<Produto>? Produtos {get; set;}
        
        public int NotaDeVenda_Id {get;set;}
        public virtual NotaDeVenda? NotaDeVenda {get; set;}
    }
}