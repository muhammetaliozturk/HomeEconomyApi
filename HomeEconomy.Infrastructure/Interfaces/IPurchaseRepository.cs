using HomeEconomyApi.Core.Entities;

namespace HomeEconomyApi.Infrastructure.Interfaces
{
    public interface IPurchaseRepository : IGenericRepository<Purchase>
    {
        //Purchase GetCurrentProcessByFRId(int failureReportingId);
    }
}