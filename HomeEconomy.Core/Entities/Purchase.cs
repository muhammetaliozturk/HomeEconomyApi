
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeEconomyApi.Core.Entities
{
    public class Purchase : BaseEntity
    {
        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(250)]
        public string PurchasePlace { get; set; }

        [Required]
        public decimal Cost { get; set; }

        public bool IsInstallment { get; set; }

        public int? InstallmentOrder { get; set; }

        public int? InstallmentId { get; set; }

        [ForeignKey("InstallmentId")]
        public Installment? Installment { get; set; }
    }
}
