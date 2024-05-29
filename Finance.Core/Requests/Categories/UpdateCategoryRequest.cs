using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        public long Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O Campo {0} inválido.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo {0} inválido.")]
        public string? Description { get; set; }
    }
}
