
using System.ComponentModel.DataAnnotations;

namespace bianca.Models
{
    public class Marca
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}
        public virtual ICollection<Produto>? Produtos {get; set;}
    }
}