using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.Negocio.Interface
{
    public interface ISolicitacaoNegocio
    {
        int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
