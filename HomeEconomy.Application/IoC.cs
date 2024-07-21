using HomeEconomyApi.Application.Interfaces;
using HomeEconomyApi.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HomeEconomyApi.Application
{
    public static class IoC
    {
        public static void ConfiguraApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IInstallmentInterface, InstallmentService>();
            services.AddScoped(typeof(IInstallmentInterface), typeof(InstallmentService));

            services.AddScoped<IPurchaseInterface, PurchaseService>();
            services.AddScoped(typeof(IPurchaseInterface), typeof(PurchaseService));
        }
    }
}
