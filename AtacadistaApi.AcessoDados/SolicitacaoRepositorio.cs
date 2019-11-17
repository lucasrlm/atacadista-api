using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;
using AtacadistaApi.Util.Enum;

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

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus)
        {
            return;
        }
    }
}
