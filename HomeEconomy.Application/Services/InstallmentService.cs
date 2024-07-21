using AutoMapper;
using HomeEconomyApi.Application.Interfaces;
using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;
using HomeEconomyApi.Infrastructure.Interfaces;

namespace HomeEconomyApi.Application.Services
{
    public class InstallmentService : IInstallmentInterface
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InstallmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Installment> GetInstallments()
        {
            return _unitOfWork.InstallmentRepository.GetAll();
        }

        public IEnumerable<Installment> GetActiveInstallments()
        {
            return _unitOfWork.InstallmentRepository.Where(x => x.IsActive);
        }

        public Installment GetInstallment(int installment)
        {
            return _unitOfWork.InstallmentRepository.GetByID(installment);
        }

        public void CreateInstallment(InstallmentReq installmentReq)
        {
            var installment = _mapper.Map<Installment>(installmentReq);

            installment.IsActive = true;
            installment.CreateDate = DateTime.Now;
            installment.CreateUserId = 1;

            _unitOfWork.InstallmentRepository.Create(installment);
        }

        public void DeleteInstallment(int id)
        {
            var deletedInstallment = _unitOfWork.InstallmentRepository.GetByID(id);

            deletedInstallment.UpdateDate = DateTime.Now;
            deletedInstallment.UpdateUserId = 1;

            _unitOfWork.InstallmentRepository.Update(deletedInstallment);
        }

        public void UpdateInstallment(int id, InstallmentReq installmentReq)
        {
            var updatedInstallment = _unitOfWork.InstallmentRepository.GetByID(id);
            updatedInstallment = _mapper.Map<Installment>(installmentReq);

            updatedInstallment.UpdateDate = DateTime.Now;
            updatedInstallment.UpdateUserId = 1;

            _unitOfWork.InstallmentRepository.Update(updatedInstallment);
        }
    }
}
