using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;

namespace HomeEconomyApi.Application.Interfaces
{
    public interface IInstallmentInterface
    {
        Installment GetInstallment(int installmentId);
        IEnumerable<Installment> GetActiveInstallments();
        IEnumerable<Installment> GetInstallments();
        void CreateInstallment(InstallmentReq installmentReq);
        void UpdateInstallment(int id, InstallmentReq installmentReq);
        void DeleteInstallment(int id);
    }
}
