using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }
        [Display(Name = "Preço")]
        public double preco { get; set; }
        public virtual Marca? Marca { get; set; }
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public virtual ICollection<Item>? Item { get; set; }


    }
}