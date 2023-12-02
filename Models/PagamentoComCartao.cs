using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do Cartão")]
        public int NumeroDoCartao { get; set; }
        [Display(Name = "Bandeira do Cartão")]
        public string? Bandeira { get; set; }
    }
}