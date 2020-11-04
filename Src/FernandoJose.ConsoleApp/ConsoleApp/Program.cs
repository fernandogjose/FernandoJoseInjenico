using FernandoJose.Application.ViewModels;
using System;

namespace ConsoleApp
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a calculadora de idade");
            Console.WriteLine("");
            string calcularNovamente;

            do
            {
                Console.WriteLine("Favor adicionar a sua data de nascimento no formato dd/mm/aaaa");
                Console.WriteLine("");

                PessoaCalcularIdadeRequestViewModel pessoaCalcularIdadeRequestViewModel = new PessoaCalcularIdadeRequestViewModel(Console.ReadLine());
                PessoaCalcularIdadeResponseViewModel pessoaCalcularIdadeResponseViewModel = PessoaAppService.CalcularAniversario(pessoaCalcularIdadeRequestViewModel);

                Console.WriteLine("");
                if (pessoaCalcularIdadeResponseViewModel.Erros != null && pessoaCalcularIdadeResponseViewModel.Erros.Count > 0)
                {
                    Console.WriteLine("Erros encontrados:");

                    foreach (var erro in pessoaCalcularIdadeResponseViewModel.Erros)
                    {
                        Console.WriteLine($":: {erro}");
                    }
                }
                else
                {
                    Console.WriteLine($"Você nasceu em: {pessoaCalcularIdadeResponseViewModel.DataDeNascimento}");
                    Console.WriteLine($"Sua idade é: {pessoaCalcularIdadeResponseViewModel.Idade}");
                }

                Console.WriteLine("");
                Console.WriteLine("Favor selecione 1 para calcular uma nova idade ou outra tecla para fechar");
                Console.WriteLine("");
                calcularNovamente = Console.ReadLine();
            } while (calcularNovamente == "1");
        }
    }
}
