using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Número do Banco")]
        public int Banco { get; set; }
        [Display(Name = "Nome do Banco")]
        public string? NomeDoBanco { get; set; }
    }
}