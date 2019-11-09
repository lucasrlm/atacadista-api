using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.AcessoDados
{
    public class SolicitacaoRepositorio : ISolicitacaoRepositorio
    {
        public int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return 1;
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return;
        }
    }
}
