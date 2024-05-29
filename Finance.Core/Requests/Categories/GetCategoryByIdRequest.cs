using System.ComponentModel.DataAnnotations;

namespace Finance.Core.Requests.Categories
{
    public class GetCategoryByIdRequest : Request
    {
        public long Id { get; set; }
    }
}
