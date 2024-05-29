using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        public long Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "{0} inválido")]
        [StringLength(80, ErrorMessage = "{0} deve ter no máximo {1} caracteres.")]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "{0} inválido.")]
        public string? Description { get; set; }
    }
}
