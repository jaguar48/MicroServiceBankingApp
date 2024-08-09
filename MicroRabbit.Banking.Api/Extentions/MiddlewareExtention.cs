

using MicroRabbit.infra.IoC;

namespace MicroRabbit.Banking.Api.Extentions
{
    public static class MiddlewareExtention
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            DependencyContainer.RegisterServices(services);
        }
    }
}
