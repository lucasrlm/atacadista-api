using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;

namespace AtacadistaApi.AcessoDados.Interface
{
    public interface ISolicitacaoRepositorio
    {
        RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao);

        void AlterarSolicitacao(int solicitacaoId, SolicitacaoRequisicao solicitacaoRequisicao);
    }
}
