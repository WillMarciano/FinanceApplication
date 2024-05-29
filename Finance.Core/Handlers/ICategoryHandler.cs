using Finance.Core.Models;
using Finance.Core.Requests.Categories;
using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface ICategoryHandler : IHandler<CreateCategoryRequest, Category>
    {
        Task<PagedResponse<List<Category?>>> GetAllAsync(GetAllCategoryRequest request);
    }
}
