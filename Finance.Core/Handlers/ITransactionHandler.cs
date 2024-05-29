using Finance.Core.Requests.Transactions;
using Finance.Core.Responses;
using System.Transactions;

namespace Finance.Core.Handlers
{
    public interface ITransactionHandler : IHandler<CreateTransactionRequest, Transaction>
    {
        Task<PagedResponse<List<Transaction?>>> GetByPeriodAsync(GetTransactionByPeriodRequest request);
    }
}
