using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.Negocio.Interface
{
    public interface ISolicitacaoNegocio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
