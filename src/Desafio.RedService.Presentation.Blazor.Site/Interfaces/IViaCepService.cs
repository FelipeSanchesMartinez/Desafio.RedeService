using Desafio.RedService.Presentation.Blazor.Site.Entities;

namespace Desafio.RedService.Presentation.Blazor.Site.Interfaces
{
    public interface IViaCepService
    {
        Task<ViaCepModel> ObterPorCep(string cep);
    }
}