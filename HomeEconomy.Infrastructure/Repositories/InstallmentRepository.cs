using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Infrastructure.Data;
using HomeEconomyApi.Infrastructure.Interfaces;

namespace HomeEconomyApi.Infrastructure.Repositories
{
    public class InstallmentRepository : GenericRepository<Installment>, IInstallmentRepository
    {       
        public InstallmentRepository(HomeEconomyDBContext dbContext) : base(dbContext)
        {
        }

        public virtual Installment GetCurrentProcessByFRId(int failureReportingId)
        {
            return transmitterDBContext.Set<Installment>()
                .First(x => x.Id == failureReportingId && x.IsActive);
        }
    }
}
