using AutoMapper;
using HomeEconomyApi.Application.Interfaces;
using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;
using HomeEconomyApi.Infrastructure.Interfaces;

namespace HomeEconomyApi.Application.Services
{
    public class PurchaseService : IPurchaseInterface
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PurchaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Purchase> GetPurchases()
        {
            return _unitOfWork.PurchaseRepository.GetAll();
        }

        public IEnumerable<Purchase> GetActivePurchases()
        {
            return _unitOfWork.PurchaseRepository.Where(x => x.IsActive);
        }

        public Purchase GetPurchase(int purchase)
        {
            return _unitOfWork.PurchaseRepository.GetByID(purchase);
        }

        public void CreatePurchase(PurchaseReq purchaseReq)
        {
            var purchase = _mapper.Map<Purchase>(purchaseReq);

            purchase.IsActive = true;
            purchase.CreateDate = DateTime.Now;
            purchase.CreateUserId = 1;

            _unitOfWork.PurchaseRepository.Create(purchase);
        }

        public void DeletePurchase(int id)
        {
            var deletedPurchase = _unitOfWork.PurchaseRepository.GetByID(id);

            deletedPurchase.UpdateDate = DateTime.Now;
            deletedPurchase.UpdateUserId = 1;

            _unitOfWork.PurchaseRepository.Update(deletedPurchase);
        }

        public void UpdatePurchase(int id, PurchaseReq purchaseReq)
        {
            var updatedPurchase = _unitOfWork.PurchaseRepository.GetByID(id);
            updatedPurchase = _mapper.Map<Purchase>(purchaseReq);

            updatedPurchase.UpdateDate = DateTime.Now;
            updatedPurchase.UpdateUserId = 1;

            _unitOfWork.PurchaseRepository.Update(updatedPurchase);
        }
    }
}
