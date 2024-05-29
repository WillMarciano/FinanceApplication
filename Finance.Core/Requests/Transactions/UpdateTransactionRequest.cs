using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Transactions
{
    public class UpdateTransactionRequest : Request
    {
        public long Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "{0} inválido")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "{0} inválido")]
        public decimal Amount { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "{0} inválida")]
        public long CategoryId { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "{0} inválida")]
        public DateTime? PaidOrRequestAt { get; set; }
    }
}
