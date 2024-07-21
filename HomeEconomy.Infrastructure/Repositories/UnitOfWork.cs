using HomeEconomyApi.Infrastructure.Data;
using HomeEconomyApi.Infrastructure.Interfaces;

namespace HomeEconomyApi.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private HomeEconomyDBContext homeEconomyDBContext;

        private IInstallmentRepository installmentRepository;
        private IPurchaseRepository purchaseRepository;

        public UnitOfWork(HomeEconomyDBContext homeEconomyDBContext)
        {
            this.homeEconomyDBContext = homeEconomyDBContext;
        }

        public IInstallmentRepository InstallmentRepository
        {
            get
            {

                if (this.installmentRepository == null)
                {
                    this.installmentRepository = new InstallmentRepository(homeEconomyDBContext);
                }
                return this.installmentRepository;
            }
        }

        public IPurchaseRepository PurchaseRepository
        {
            get
            {

                if (this.purchaseRepository == null)
                {
                    this.purchaseRepository = new PurchaseRepository(homeEconomyDBContext);
                }
                return this.purchaseRepository;
            }
        }
    }
}
