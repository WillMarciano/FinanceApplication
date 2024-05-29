using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface IHandler<TCreateRequest, TUpdateRequest, TDeleteRequest, TGetByIdRequest, TResponse>
    {
        Task<Response<TResponse?>> CreateAsync(TCreateRequest request);
        Task<Response<TResponse?>> UpdateAsync(TUpdateRequest request);
        Task<Response<TResponse?>> DeleteAsync(TDeleteRequest request);
        Task<Response<TResponse?>> GetByIdAsync(TGetByIdRequest request);
    }
}
