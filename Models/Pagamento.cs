using System;
using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public class Pagamento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Data limite")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
        [Display(Name = "Está Pago")]
        public bool EstaPago { get; set; }
        public virtual ICollection<NotaDeVenda>? NotaDeVendas { get; set; }

    }
}
