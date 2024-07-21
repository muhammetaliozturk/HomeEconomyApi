
using System.ComponentModel.DataAnnotations;

namespace HomeEconomyApi.Core.Entities
{
    public class Installment : BaseEntity
    {
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(250)]
        public string? PurchasePlace { get; set; }

        public decimal TotalCost { get; set; }

        public int InstallmentNumber { get; set; }

        public IEnumerable<Purchase>? Purchases { get; set; }
    }
}
