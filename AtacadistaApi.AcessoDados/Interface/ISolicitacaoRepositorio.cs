using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        int CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
