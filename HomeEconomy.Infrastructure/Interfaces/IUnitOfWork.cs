namespace HomeEconomyApi.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IInstallmentRepository InstallmentRepository { get; }
        IPurchaseRepository PurchaseRepository { get; }
    }
}
