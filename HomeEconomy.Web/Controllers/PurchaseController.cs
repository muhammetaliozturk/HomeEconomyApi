using HomeEconomyApi.Application.Interfaces;
using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEconomyApi.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController
    {
        private readonly ILogger<PurchaseController> _logger;
        private readonly IPurchaseInterface _purchaseInterface;

        public PurchaseController(ILogger<PurchaseController> logger, IPurchaseInterface purchaseInterface)
        {
            _logger = logger;
            _purchaseInterface = purchaseInterface;
        }

        [HttpGet("all")]
        public IEnumerable<Purchase> GetPurchases() => _purchaseInterface.GetPurchases();

        [HttpGet("all-active")]
        public IEnumerable<Purchase> GetActivePurchases() => _purchaseInterface.GetActivePurchases();

        [HttpGet("{id}")]
        public Purchase GetPurchase(int id) => _purchaseInterface.GetPurchase(id);

        [HttpPost("")]
        public void Create([FromBody] PurchaseReq purchaseReq) => _purchaseInterface.CreatePurchase(purchaseReq);

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] PurchaseReq purchaseReq) => _purchaseInterface.UpdatePurchase(id, purchaseReq);

        [HttpDelete("{id}")]
        public void Delete(int id) => _purchaseInterface.DeletePurchase(id);
    }
}
