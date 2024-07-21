using AutoMapper;
using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;

namespace HomeEconomyApi.Core.Mapper
{
    public class PurchaseProfile : Profile
    {
        public PurchaseProfile()
        {
            CreateMap<PurchaseReq, Purchase>();
            CreateMap<Purchase, PurchaseReq>();
        }
    }
}
