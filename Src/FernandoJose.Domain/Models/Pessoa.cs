using System;
using System.Collections.Generic;
using System.Globalization;

namespace FernandoJose.Domain.Models
{
    public class Pessoa
    {
        public DateTime DataDeNascimento { get; private set; }

        public string Idade { get; private set; }

        public List<string> Erros { get; private set; }

        private void AdicionarErro(string mensagem)
        {
            if (Erros == null)
            {
                Erros = new List<string>(0);
            }

            Erros.Add(mensagem);
        }

        private void ValidarDataDeNascimento(string dataDeNascimento)
        {
            if (!DateTime.TryParse(dataDeNascimento, new CultureInfo("pt-BR"), DateTimeStyles.None, out var dataDeNascimentoFormatada))
            {
                AdicionarErro("Data de nascimento inválida, favor verificar e tentar novamente");
            }

            if (dataDeNascimentoFormatada > DateTime.Now)
            {
                AdicionarErro("Data de nascimento deve ser menor que a data atual");
            }
        }

        public void PreencherDataDeNascimento(string dataDeNascimento)
        {
            ValidarDataDeNascimento(dataDeNascimento);

            if (Erros == null || Erros.Count == 0)
                DataDeNascimento = Convert.ToDateTime(dataDeNascimento, new CultureInfo("pt-BR"));
        }

        public void PreencherIdade(string idade)
        {
            Idade = idade;
        }
    }
}
