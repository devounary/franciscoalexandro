using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class Item
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public virtual Produto? Produto { get; set; }
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public virtual ICollection<NotaDeVenda>? NotaDeVendas { get; set; }

    }
}