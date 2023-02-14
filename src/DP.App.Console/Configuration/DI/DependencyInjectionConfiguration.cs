using DP.Core.Creational_Patterns.Builder.Builders;
using DP.Core.Creational_Patterns.Builder.Builders.Base;
using DP.Core.Creational_Patterns.Builder.Director;
using DP.Core.Structural_Patterns.Adapter;
using DP.Core.Structural_Patterns.Adapter.Exemplo_1;
using Microsoft.Extensions.DependencyInjection;

namespace DP.App.Console.Configuration.DI
{
    public static class DependencyInjectionConfiguration
    {

        public static IServiceProvider BuscarServiceProvider()
        {
            return ConfigureServices(new ServiceCollection());
        }
        private static IServiceProvider ConfigureServices(IServiceCollection services)
        {

            services.AddScoped<CarroBuilderDirector>();

            services.AddScoped<CarroEsportivoBuilder>();
            services.AddScoped<CarroHatchBuilder>();
            services.AddScoped<CarroPeruaBuilder>();

            ResolveDIAdapter(services);
            

            return services.BuildServiceProvider();
        }


        private static void ResolveDIAdapter(IServiceCollection services)
        {
            services.AddScoped<IAdapter<AdapterEx1>, AdapterEx1>();
            services.AddScoped<ILogger<Logger>, Logger>();
            services.AddScoped<ILogger<LogAdapter>, LogAdapter>();
            services.AddScoped<ILoggerNetMaster, LoggerNetMaster>();
        }
    }
}
