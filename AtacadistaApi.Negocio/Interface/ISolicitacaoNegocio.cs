using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;
using AtacadistaApi.Util.Enum;

namespace AtacadistaApi.Negocio.Interface
{
    public interface ISolicitacaoNegocio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus);
    }
}
