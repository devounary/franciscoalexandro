using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class Transportadora
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        public virtual ICollection<NotaDeVenda>? NotaDeVendas { get; set; }

    }
}