using Finance.Core.Models;
using Finance.Core.Requests.Transactions;
using Finance.Core.Responses;


namespace Finance.Core.Handlers
{
    public interface ITransactionHandler : IHandler<CreateTransactionRequest, UpdateTransactionRequest, DeleteTransactionRequest, GetTransactionByIdRequest, Transaction>
    {
        Task<PagedResponse<List<Transaction>?>> GetByPeriodAsync(GetTransactionsByPeriodRequest request);
    }
}
