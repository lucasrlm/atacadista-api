using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;
using AtacadistaApi.Util.Enum;

namespace AtacadistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus);
    }
}
