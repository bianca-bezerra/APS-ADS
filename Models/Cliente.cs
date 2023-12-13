namespace bianca.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string? Nome {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}