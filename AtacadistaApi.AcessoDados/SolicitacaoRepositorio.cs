using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.AcessoDados
{
    public class SolicitacaoRepositorio : ISolicitacaoRepositorio
    {
        public RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return new RetornoBase()
            {
                Id = 1
            };
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return;
        }
    }
}
