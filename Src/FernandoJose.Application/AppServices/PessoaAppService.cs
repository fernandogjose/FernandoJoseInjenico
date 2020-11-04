using FernandoJose.Application.Interfaces;
using FernandoJose.Application.ViewModels;
using FernandoJose.Domain.Interfaces.Services;
using FernandoJose.Domain.Models;

namespace FernandoJose.Application.AppServices
{
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public PessoaCalcularIdadeResponseViewModel CalcularAniversario(PessoaCalcularIdadeRequestViewModel pessoaCalcularIdadeRequestViewModel)
        {
            Pessoa pessoaRequest = new Pessoa();
            pessoaRequest.PreencherDataDeNascimento(pessoaCalcularIdadeRequestViewModel.DataDeNascimento);

            if (pessoaRequest.Erros != null && pessoaRequest.Erros.Count > 0)
            {
                return new PessoaCalcularIdadeResponseViewModel(pessoaRequest.DataDeNascimento, "", pessoaRequest.Erros);
            }

            Pessoa pessoaResponse = _pessoaService.CalcularIdade(pessoaRequest);
            return new PessoaCalcularIdadeResponseViewModel(pessoaRequest.DataDeNascimento, pessoaResponse.Idade, null);
        }
    }
}
