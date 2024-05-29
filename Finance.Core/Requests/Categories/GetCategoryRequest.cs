using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class GetCategoryRequest : Request
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        public long Id { get; set; }
    }
}
