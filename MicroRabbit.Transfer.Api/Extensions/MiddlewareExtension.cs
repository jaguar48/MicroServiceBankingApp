using MicroRabbit.infra.IoC;

namespace MicroRabbit.Transfer.Api.Extensions
{
    public static class MiddlewareExtention
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            DependencyContainer.RegisterServices(services);
        }
    }
}
