using System;
using System.Collections.Generic;

namespace FernandoJose.Application.ViewModels
{
    public class PessoaCalcularIdadeRequestViewModel
    {
        public string DataDeNascimento { get; set; }

        public PessoaCalcularIdadeRequestViewModel(string dataDeNascimento)
        {
            DataDeNascimento = dataDeNascimento;
        }
    }

    public class PessoaCalcularIdadeResponseViewModel
    {
        public DateTime DataDeNascimento { get; set; }

        public string Idade { get; set; }

        public List<string> Erros { get; set; }

        public PessoaCalcularIdadeResponseViewModel(DateTime dataDeNascimento, string idade, List<string> erros)
        {
            DataDeNascimento = dataDeNascimento;
            Idade = idade;
            Erros = erros;
        }
    }
}
