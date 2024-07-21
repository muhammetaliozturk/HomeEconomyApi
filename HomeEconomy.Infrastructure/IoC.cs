using HomeEconomyApi.Infrastructure.Repositories;
using HomeEconomyApi.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HomeEconomyApi.Infrastructure
{
    public static class IoC
    {
        public static void ConfiguraApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
