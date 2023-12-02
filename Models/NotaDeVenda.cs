using System.ComponentModel.DataAnnotations;

namespace franciscoalexandro.Models
{
    public enum StatusVenda
    {
        [Display(Name = "Ativo")]
        Ativo = 1,
        [Display(Name = "Cancelado")]
        Cancelado = 2,
        [Display(Name = "Devolvido")]
        Devolvido = 3
    }
    public class NotaDeVenda
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime Data { get; set; }
        [Display(Name = "Status")]
        public StatusVenda Status { get; set; }
        public virtual Cliente? Cliente { get; set; }
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public virtual Vendedor? Vendedor { get; set; }
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }
        public virtual Transportadora? Transportadora { get; set; }
        [Display(Name = "Transportadora")]
        public int TransportadoraId { get; set; }
        public virtual Pagamento? Pagamento { get; set; }
        [Display(Name = "Pagamento")]
        public int PagamentoId { get; set; }
        public virtual Item? Item { get; set; }
        [Display(Name = "Item")]
        public int ItemId { get; set; }
        public virtual TipoDePagamento? TipoDePagamento { get; set; }
        [Display(Name = "Tipo de Pagamento")]
        public int TipoDePagamentoId { get; set; }

        public void Cancelar()
        {
            Status = StatusVenda.Cancelado;
            Console.WriteLine("A nota de venda foi cancelada com sucesso.");
        }

        public void Devolver()
        {
            Status = StatusVenda.Devolvido;
            Console.WriteLine("Os produtos foram devolvidos.");
        }
    }
}
