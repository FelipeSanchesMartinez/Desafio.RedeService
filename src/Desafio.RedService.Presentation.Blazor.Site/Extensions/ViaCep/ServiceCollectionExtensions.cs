using Desafio.RedService.Presentation.Blazor.Site.Interfaces;
using Desafio.RedService.Presentation.Blazor.Site.Services;

using Microsoft.Extensions.DependencyInjection;

namespace Desafio.RedService.Presentation.Blazor.Site.Extensions.ViaCep
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddViaCep(this IServiceCollection services)
        {
            services.AddHttpClient("viacep", httpClient => httpClient.BaseAddress = new Uri("https://viacep.com.br/ws/"));

            services.AddScoped<IViaCepService, ViaCepService>();

            return services;
        }
    }
}
