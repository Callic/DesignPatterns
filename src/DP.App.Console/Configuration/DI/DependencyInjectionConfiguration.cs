using DP.Core.Creational_Patterns.Builder.Builders;
using DP.Core.Creational_Patterns.Builder.Builders.Base;
using DP.Core.Creational_Patterns.Builder.Director;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            return services.BuildServiceProvider();
        }
    }
}
