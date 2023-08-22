using Desafio.RedService.Presentation.Blazor.Site.Entities;
using Desafio.RedService.Presentation.Blazor.Site.Interfaces;
using System.Net.Http.Json;

namespace Desafio.RedService.Presentation.Blazor.Site.Services
{
    public class ViaCepService : IViaCepService
    {
        private readonly HttpClient _httpClient;
        public ViaCepService(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("viacep");
        }

        public async Task<ViaCepModel> ObterPorCep(string cep)
        {
            try
            {
                string query = $"{cep}/json";
                var response = await _httpClient.GetAsync(query);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadFromJsonAsync<ViaCepModel>();

                return null;

            }
            catch
            {
                return null;
            }
        }
    }
}
