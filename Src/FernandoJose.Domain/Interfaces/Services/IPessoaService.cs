using FernandoJose.Domain.Models;

namespace FernandoJose.Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        Pessoa CalcularIdade(Pessoa pessoaRequest);
    }
}
