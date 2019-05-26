using System;

namespace Negocio
{
    public class ValidacaoDados
    {
        public void ValidaIconsistencias(string caminhoArquivo, string colunaTempo, string colunaIntervalo, string Prec, string nomePlanilha, string caminhoSalvamento)
        {
            if (string.IsNullOrWhiteSpace(caminhoArquivo))
            {
                throw new Exception("É necessário informar o caminho do arquivo!");
            }
            if (string.IsNullOrWhiteSpace(colunaTempo))
            {
                throw new Exception("É necessário selecionar o tempo!");
            }
            if (string.IsNullOrWhiteSpace(nomePlanilha))
            {
                throw new Exception("PE necessário informar o nome da planilha!");
            }
            if (string.IsNullOrWhiteSpace(Prec))
            {
                throw new Exception("É necessário selecionar o PREC!");
            }
            if (string.IsNullOrWhiteSpace(caminhoSalvamento))
            {
                throw new Exception("É necessário informar o caminho em que o arquivo .xlsx será salvo!");
            }
        }
    }
}
