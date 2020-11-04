using FernandoJose.Application.ViewModels;

namespace FernandoJose.Application.Interfaces
{
    public interface IPessoaAppService
    {
        PessoaCalcularIdadeResponseViewModel CalcularAniversario(PessoaCalcularIdadeRequestViewModel pessoaCalcularIdadeRequestViewModel);
    }
}
