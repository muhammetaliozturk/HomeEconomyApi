using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Infrastructure.Data;
using HomeEconomyApi.Infrastructure.Interfaces;

namespace HomeEconomyApi.Infrastructure.Repositories
{
    public class PurchaseRepository : GenericRepository<Purchase>, IPurchaseRepository
    {       
        public PurchaseRepository(HomeEconomyDBContext dbContext) : base(dbContext)
        {
        }

        public virtual Purchase GetCurrentProcessByFRId(int failureReportingId)
        {
            return transmitterDBContext.Set<Purchase>()
                .First(x => x.Id == failureReportingId && x.IsActive);
        }
    }
}
