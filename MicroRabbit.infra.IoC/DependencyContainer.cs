


using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;

namespace MicroRabbit.infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection  services)
        {
            // Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data

            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddTransient<BankingDbContext>();
        }
    }
}
