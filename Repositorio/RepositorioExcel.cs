using ClosedXML.Excel;
using Negocio;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class RepositorioExcel
    {
        public List<Resultado> CapturaValorPlanilha(string caminho, string colunaTempo, string colunaIntervalo, string colunaPREC, string nomePlanilha, int linhaInicial)
        {
            var wb = new XLWorkbook(caminho);
            var planilha = wb.Worksheet(nomePlanilha);
            List<Excel> listaExcel = new List<Excel>();
            int linhaInicialDaPlanilha = linhaInicial;
            while (true)
            {
                Excel excel = new Excel();
                var tempo = planilha.Cell(colunaTempo + linhaInicialDaPlanilha.ToString()).Value.ToString();
                bool ehFormatado = false;

                if (!string.IsNullOrWhiteSpace(tempo))
                {

                    var dataString = (planilha.Cell(colunaTempo + linhaInicialDaPlanilha.ToString()).Value.ToString()).Split(' ');
                    var horaString = dataString[1].Split('m');
                    var vetorHora = horaString[0].ToCharArray();
                    string data = dataString[0];
                    DateTime dataConvertida = Convert.ToDateTime(data);
                    for (int i = 0; i < vetorHora.Length; i++)
                    {
                        if (vetorHora[i] == 'H')
                        {
                            ehFormatado = true;
                        }
                    }

                    if (ehFormatado)
                    {
                        string time = horaString[0].Replace("H", ":");
                        dataConvertida = dataConvertida + TimeSpan.Parse(time);
                    }
                    else
                    {
                        string hora = "";
                        for (int i = 0; i < vetorHora.Length; i++)
                        {
                            while (i < 5)
                            {
                                hora += vetorHora[i];
                                i++;
                            }
                            break;
                        }
                        dataConvertida = dataConvertida + TimeSpan.Parse(hora);
                    }

                    excel.Id = Convert.ToInt32(planilha.Cell("A" + linhaInicialDaPlanilha.ToString()).Value.ToString());
                    excel.DataEhHora = dataConvertida;

                    var PREC = planilha.Cell(colunaPREC + linhaInicialDaPlanilha.ToString()).Value.ToString();

                    if (String.IsNullOrWhiteSpace(PREC))
                    {
                        PREC = 0.ToString();
                    }
                    excel.PREC = Convert.ToDecimal(PREC);
                    listaExcel.Add(excel);
                    linhaInicialDaPlanilha++;
                }
                else
                {
                    break;
                }
            }


            return realizaOperacao(listaExcel, colunaIntervalo, linhaInicial);
        }

        public List<Resultado> realizaOperacao(List<Excel> lista, string intervalo, int linhaInicial)
        {
            int intervaloConvertido = Convert.ToInt32(intervalo);
            return operadorAuxiliar(lista, intervaloConvertido, linhaInicial, true);
        }

        public List<Resultado> operadorAuxiliar(List<Excel> lista, int intervalo, int linhaInicial, bool ehMinutos)
        {
            Decimal primeiro = 0;
            DateTime dataEhHoraInicial;
            DateTime dataEhHoraFinal;
            DateTime data = new DateTime();
            TimeSpan resultado = TimeSpan.Zero;
            int resultadoInt;
            var arrayExcel = lista.ToArray();
            int tamanho = arrayExcel.Length;
            List<Resultado> listaResultado = new List<Resultado>();
            for (int i = 0; i < arrayExcel.Length; i++)
            {
                Resultado resultadoExcel = new Resultado();

                if (i == 0)
                {
                    primeiro = arrayExcel[i].PREC;
                    data = arrayExcel[i].DataEhHora;
                }


                if (tamanho > i + 1)
                {
                    dataEhHoraInicial = arrayExcel[i].DataEhHora;
                    dataEhHoraFinal = arrayExcel[i + 1].DataEhHora;

                    resultado = resultado + dataEhHoraFinal.Subtract(dataEhHoraInicial);

                    resultadoInt = (int)resultado.TotalMinutes;

                    if (resultadoInt < intervalo)
                    {
                        continue;
                    }

                    else if (resultadoInt == intervalo)
                    {
                        if (arrayExcel[i + 1].PREC < primeiro)
                        {
                            resultadoExcel.PREC = primeiro;
                            resultadoExcel.Data = data;
                            listaResultado.Add(resultadoExcel);
                            primeiro = arrayExcel[i + 1].PREC;
                            resultado = TimeSpan.Zero;
                            continue;
                        }
                        resultadoExcel.PREC = arrayExcel[i + 1].PREC - primeiro;
                        resultadoExcel.Data = arrayExcel[i + 1].DataEhHora;
                        listaResultado.Add(resultadoExcel);
                        primeiro = arrayExcel[i + 1].PREC;
                        resultado = TimeSpan.Zero;
                        continue;
                    }
                    else
                    {
                        primeiro = arrayExcel[i].PREC;
                        resultado = TimeSpan.Zero;
                        continue;
                    }
                }
                else
                {
                    break;
                }
            }
            return listaResultado;
        }
    }
}
