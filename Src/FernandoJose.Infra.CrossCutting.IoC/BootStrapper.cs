using FernandoJose.Application.AppServices;
using FernandoJose.Application.Interfaces;
using FernandoJose.Domain.Interfaces.Services;
using FernandoJose.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FernandoJose.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Service
            services.AddTransient<IPessoaService, PessoaService>();

            // AppService
            services.AddTransient<IPessoaAppService, PessoaAppService>();
        }

        public static T GetService<T>()
        {
            var serviceCollection = new ServiceCollection();
            RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetService<T>();
        }
    }
}