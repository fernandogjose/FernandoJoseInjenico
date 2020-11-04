using FernandoJose.Application.Interfaces;
using FernandoJose.Infra.CrossCutting.IoC;
using System.Globalization;

namespace ConsoleApp
{
    public class ProgramBase
    {
        public ProgramBase()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
        }

        protected static IPessoaAppService PessoaAppService
        {
            get { return BootStrapper.GetService<IPessoaAppService>(); }
        }
    }
}
