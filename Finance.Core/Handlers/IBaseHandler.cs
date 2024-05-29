using Finance.Core.Responses;

namespace Finance.Core.Handlers
{
    public interface IHandler<TRequest, TResponse>
    {
        Task<Response<TResponse>> CreateAsync(TRequest request);
        Task<Response<TResponse>> DeleteAsync(TRequest request);
        Task<Response<TResponse>> GetByIdAsync(TRequest request);
        Task<Response<TResponse>> UpdateAsync(TRequest request);
    }
}
