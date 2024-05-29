using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class DeleteCategoryRequest : Request
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public long Id { get; set; }
    }
}
