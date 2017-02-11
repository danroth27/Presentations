using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateScopes
{
    public class ValidateScopesServiceProviderFactory : IServiceProviderFactory<IServiceCollection>
    {
        public IServiceCollection CreateBuilder(IServiceCollection services)
        {
            return services;
        }

        public IServiceProvider CreateServiceProvider(IServiceCollection containerBuilder)
        {
            return containerBuilder.BuildServiceProvider(validateScopes: true);
        }
    }

    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UseScopeValidation(this IWebHostBuilder webHostBuilder)
        {
            return webHostBuilder.ConfigureServices(services =>
            {
                services.AddSingleton<IServiceProviderFactory<IServiceCollection>, ValidateScopesServiceProviderFactory>();
            });
        }
    }
}
