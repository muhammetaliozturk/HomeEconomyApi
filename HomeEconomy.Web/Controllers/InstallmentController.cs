using HomeEconomyApi.Application.Interfaces;
using HomeEconomyApi.Core.Entities;
using HomeEconomyApi.Core.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeEconomyApi.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstallmentController
    {
        private readonly ILogger<InstallmentController> _logger;
        private readonly IInstallmentInterface _installmentInterface;

        public InstallmentController(ILogger<InstallmentController> logger, IInstallmentInterface installmentInterface)
        {
            _logger = logger;
            _installmentInterface = installmentInterface;
        }

        [HttpGet("all")]
        public IEnumerable<Installment> GetInstallments() => _installmentInterface.GetInstallments();

        [HttpGet("all-active")]
        public IEnumerable<Installment> GetActiveInstallments() => _installmentInterface.GetActiveInstallments();

        [HttpGet("{id}")]
        public Installment GetInstallment(int id) => _installmentInterface.GetInstallment(id);

        [HttpPost("")]
        public void Create([FromBody] InstallmentReq installmentReq) => _installmentInterface.CreateInstallment(installmentReq);

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] InstallmentReq installmentReq) => _installmentInterface.UpdateInstallment(id, installmentReq);

        [HttpDelete("{id}")]
        public void Delete(int id) => _installmentInterface.DeleteInstallment(id);
    }
}
