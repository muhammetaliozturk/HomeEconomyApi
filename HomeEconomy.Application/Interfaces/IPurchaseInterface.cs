using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;

namespace HomeEconomyApi.Application.Interfaces
{
    public interface IPurchaseInterface
    {
        Purchase GetPurchase(int PurchaseId);
        IEnumerable<Purchase> GetPurchases();
        IEnumerable<Purchase> GetActivePurchases();
        void CreatePurchase(PurchaseReq purchaseReq);
        void UpdatePurchase(int id, PurchaseReq purchaseReq);
        void DeletePurchase(int id);
    }
}
