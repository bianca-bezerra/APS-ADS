using System.ComponentModel.DataAnnotations;

namespace bianca.Models

{
    public class Produto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}
        public int Quantidade {get; set;}
        [Display(Name = "Preço")]
        public double Preco {get; set;}
        [Display(Name = "Id do Item")]
        public int Item_Id {get; set;}
        public virtual Item? Item {get; set;}
        [Display(Name = "Id da Marca")]
        public int Marca_Id {get;set;}
        public virtual Marca? Marca {get; set;}
    }
}