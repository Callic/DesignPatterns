using DP.Core.Behavioral_Patterns.Command;
using DP.Core.Behavioral_Patterns.Strategy;
using DP.Core.Behavioral_Patterns.Strategy.Interfaces;
using DP.Core.Creational_Patterns.Builder.Builders;
using DP.Core.Creational_Patterns.Builder.Director;
using DP.Core.Structural_Patterns.Adapter;
using DP.Core.Structural_Patterns.Adapter.Exemplo_1;
using DP.Core.Structural_Patterns.Composite;
using DP.Core.Structural_Patterns.Facade.Exemplo_1;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Clients;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DP.App.Console.Configuration.DI
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceProvider BuildServiceProvider(IConfiguration configuration)
        {
            return ConfigureServices(new ServiceCollection(), configuration);
        }
        private static IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);

            Builder(services);
            
            Adapter(services);
            Facade(services);
            Composite(services);
            Command(services);
            Strategy(services);


            return services.BuildServiceProvider();
        }

        private static void Builder(IServiceCollection services)
        {
            services.AddScoped<CarroBuilderDirector>();
            services.AddScoped<CarroEsportivoBuilder>();
            services.AddScoped<CarroHatchBuilder>();
            services.AddScoped<CarroPeruaBuilder>();
        }

        private static void Adapter(IServiceCollection services)
        {
            services.AddScoped<IAdapter<AdapterEx1>, AdapterEx1>();
            services.AddScoped<ILogger<Logger>, Logger>();
            services.AddScoped<ILogger<LogAdapter>, LogAdapter>();
            services.AddScoped<ILoggerNetMaster, LoggerNetMaster>();
        }
        
        private static void Facade(IServiceCollection services)
        {
            services.AddScoped<ExecucaoFacade>();
            services.AddScoped<IPagamentoCartaoCreditoService, PagamentoCartaoCreditoService>();
            services.AddScoped<IPagamentoCartaoCreditoFacade, PagamentoCartaoCreditoFacade>();
            services.AddScoped<IPayPalGateway, PayPalGateway>();
        }
        
        private static void Composite(IServiceCollection services)
        {
            services.AddScoped<ExecucaoComposite>();
        }
        
        private static void Command(IServiceCollection services)
        {
            services.AddScoped<ExecucaoCommand>();
            services.AddScoped<Calculadora>();
            services.AddScoped<Invocador>();
            services.AddScoped<ICommand, CalculadoraCommand>();
        }
        private static void Strategy(IServiceCollection services)
        {
            services.AddScoped<ExecucaoStrategy>();
            services.AddScoped<IPagamentoBoletoService, PagamentoBoletoService>();
            services.AddScoped<PagamentoFactory>();
            services.AddScoped<PedidoService>();
        }
    }
}
