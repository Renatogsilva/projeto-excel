using Negocio;

namespace Controle
{
    public class ObjetoControlle
    {
        public void validaDadosInformados(string caminhoArquivo, string colunaTempo, string colunaIntervalo, string colunaPrec, string nomePlanilha, string caminhoSalvamento)
        {
            ValidacaoDados validacao = new ValidacaoDados();
            validacao.ValidaIconsistencias(caminhoArquivo, colunaTempo, colunaIntervalo, colunaPrec, nomePlanilha, caminhoSalvamento);
        }
    }
}
