using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Informações Adicionais")]
        public string InformacoesAdicionais { get; set; }
        public string? Discriminator { get; set; }
        public virtual ICollection<NotaDeVenda>? NotaDeVendas { get; set; }

    }
}