namespace HomeEconomyApi.Core.Models.RequestModels
{
    public class PurchaseReq
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PurchasePlace { get; set; }
        public decimal Cost { get; set; }
        public bool IsInstallment { get; set; }
        public int? InstallmentOrder { get; set; }
    }
}
