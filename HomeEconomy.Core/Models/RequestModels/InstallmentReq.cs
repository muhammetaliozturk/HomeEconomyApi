using HomeEconomyApi.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace HomeEconomyApi.Core.Models.RequestModels
{
    public class InstallmentReq
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? PurchasePlace { get; set; }
        public decimal TotalCost { get; set; }
        public int InstallmentNumber { get; set; }
    }
}
