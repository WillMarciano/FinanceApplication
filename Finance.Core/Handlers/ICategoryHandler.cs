using Finance.Core.Models;
using Finance.Core.Requests.Categories;
using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface ICategoryHandler : IHandler<CreateCategoryRequest, UpdateCategoryRequest, DeleteCategoryRequest, GetCategoryByIdRequest, Category>
    {
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllCategoriesRequest request);
    }
}
