namespace bianca.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Descricao {get; set;}
        public int Quantidade {get; set;}
        public double Preco {get; set;}

        public int Marca_Id {get;set;}
        public virtual Marca? Marca {get; set;}
        
        public int Item_Id {get; set;}
        public virtual Item? Item {get; set;}
    }
}