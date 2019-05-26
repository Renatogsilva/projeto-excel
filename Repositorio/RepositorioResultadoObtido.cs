using ClosedXML.Excel;
using Negocio;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repositorio
{
    public class RepositorioResultadoObtido
    {
        public bool GerarPlanilha(List<Resultado> lista, string intervalo, string caminhoSalvamento)
        {
            var wb = new XLWorkbook();
            var arrayResultado = lista.ToArray();

            var excelPackage = new ExcelPackage();

            excelPackage.Workbook.Properties.Author = "Ricardo";
            excelPackage.Workbook.Properties.Title = "Meu Excel";

            var planilha = excelPackage.Workbook.Worksheets.Add(intervalo + " Minutos");
            planilha.Name = intervalo + " Minutos";

            planilha.Cells["A2"].Value = "Tabela Resultado dos dados Pluviométricos";
            var renge = planilha.SelectedRange["A2: C2"];

            planilha.Cells["A3"].Value = "ANO";
            planilha.Cells["B3"].Value = "Precipitação em intervalos de " + intervalo + " Minutos (2011 a 2018)";

            var linha = 4;
            for (int i = 0; i < arrayResultado.Length; i++)
            {
                planilha.Cells[linha, 1].Value = Convert.ToDateTime(arrayResultado[i].Data.ToString()).Year;
                planilha.Cells[linha, 2].Value = Convert.ToDecimal(arrayResultado[i].PREC.ToString("0.0"));
                linha++;
            }

            linha--;

            string path = @caminhoSalvamento+".xlsx";
            File.WriteAllBytes(path, excelPackage.GetAsByteArray());
            planilha.Dispose();
            return File.Exists(path);
        }
    }
}
