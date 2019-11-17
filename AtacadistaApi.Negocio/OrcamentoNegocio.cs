using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model;
using AtacadistaApi.Model.Orcamento;
using AtacadistaApi.Negocio.Interface;

namespace AtacadistaApi.Negocio
{
    public class OrcamentoNegocio : IOrcamentoNegocio
    {
        private readonly IOrcamentoRepositorio _orcamentoRepositorio;

        public OrcamentoNegocio(IOrcamentoRepositorio orcamentoRepositorio)
        {
            _orcamentoRepositorio = orcamentoRepositorio;
        }

        public RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return _orcamentoRepositorio.CriarOrcamento(orcamentoRequisicao);
        }
    }
}
