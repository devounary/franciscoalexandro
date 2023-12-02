using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class Marca
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public virtual ICollection<Produto>? Produtos { get; set; }
    }
}