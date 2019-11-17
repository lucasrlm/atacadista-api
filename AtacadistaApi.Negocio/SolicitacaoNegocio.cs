using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model;
using AtacadistaApi.Model.Solicitacao;
using AtacadistaApi.Negocio.Interface;
using AtacadistaApi.Util.Enum;

namespace AtacadistaApi.Negocio
{
    public class SolicitacaoNegocio : ISolicitacaoNegocio
    {
        private readonly ISolicitacaoRepositorio _solicitacaoRepositorio;

        public SolicitacaoNegocio(ISolicitacaoRepositorio solicitacaoRepositorio)
        {
            _solicitacaoRepositorio = solicitacaoRepositorio;
        }

        public RetornoBase CriarSolicitacao(SolicitacaoRequisicao solicitacaoRequisicao)
        {
            return _solicitacaoRepositorio.CriarSolicitacao(solicitacaoRequisicao);
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus)
        {
            _solicitacaoRepositorio.AlterarSolicitacao(solicitacaoId, solicitacaoStatus);
        }
    }
}
