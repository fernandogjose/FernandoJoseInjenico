using FernandoJose.Domain.Interfaces.Services;
using FernandoJose.Domain.Models;
using System;

namespace FernandoJose.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private int CalcularDias(DateTime dataAtual, DateTime dataNascimento)
        {
            int dias = 0;

            if ((dataAtual.Month > dataNascimento.Month || dataAtual.Month < dataNascimento.Month) && (dataAtual.Day > dataNascimento.Day))
            {
                DateTime dataFormatada = DateTime.Parse(dataNascimento.Day.ToString() + "/" + dataAtual.Month.ToString() + "/" + dataAtual.Year.ToString());
                dias = (dataAtual - dataFormatada).Days;
            }
            else if ((dataAtual.Month > dataNascimento.Month || dataAtual.Month < dataNascimento.Month) && (dataAtual.Day < dataNascimento.Day))
            {
                DateTime dataFormatada = DateTime.Parse(dataNascimento.Day.ToString() + "/" + (dataAtual.Month - 1).ToString() + "/" + dataAtual.Year.ToString());
                dias = (dataAtual - dataFormatada).Days;
            }
            else if (dataNascimento.Month == dataAtual.Month)
            {
                DateTime dataFormatada = DateTime.Parse(dataNascimento.Day.ToString() + "/" + dataAtual.Month.ToString() + "/" + dataAtual.Year.ToString());
                dias = (dataAtual - dataFormatada).Days;
            }

            return dias;
        }

        private int CalcularMeses(DateTime dataAtual, DateTime dataNascimento)
        {
            int diaNascimento = dataNascimento.Day;
            int mesNascimento = dataNascimento.Month;

            int diaAtual = dataAtual.Day;
            int mesAtual = dataAtual.Month;

            if (mesAtual > mesNascimento)
            {
                return mesAtual - mesNascimento;
            }

            if (mesAtual < mesNascimento)
            {
                if (mesAtual > dataNascimento.Day)
                {
                    return (12 - mesNascimento) + (mesAtual);
                }

                if (diaAtual < diaNascimento)
                {
                    return (12 - mesNascimento) + (mesAtual - 1);
                }
            }

            return 0;
        }

        public Pessoa CalcularIdade(Pessoa pessoaRequest)
        {
            DateTime dataAtual = DateTime.Now;

            // calcular os anos 
            int anos = dataAtual.Year - pessoaRequest.DataDeNascimento.Year;
            if (dataAtual.Month < pessoaRequest.DataDeNascimento.Month || (dataAtual.Month == pessoaRequest.DataDeNascimento.Month && dataAtual.Day < pessoaRequest.DataDeNascimento.Day))
            {
                anos--;
            }

            // calcular os meses 
            int meses = CalcularMeses(dataAtual, pessoaRequest.DataDeNascimento);

            // calcular os dias
            int dias = CalcularDias(dataAtual, pessoaRequest.DataDeNascimento);

            string idadeAnos = anos > 1 ? anos + " anos " : anos + "ano ";
            string idadeMeses = meses > 1 ? meses + " meses " : meses + "mês ";
            string idadeDias = dias > 1 ? dias + " dias " : dias + "dia ";

            Pessoa pessoaResponse = new Pessoa();
            pessoaResponse.PreencherDataDeNascimento(pessoaRequest.DataDeNascimento.ToString());
            pessoaResponse.PreencherIdade(idadeAnos + idadeMeses + idadeDias);

            return pessoaResponse;
        }
    }
}
