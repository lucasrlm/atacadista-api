using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model.Orcamento;
using AtacadistaApi.Servicos.Interface;

namespace AtacadistaApi.AcessoDados
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        private readonly ILojistaApi _lojistaApi;

        public int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return _lojistaApi.CriarOrcamento(orcamentoRequisicao);
        }
    }
}
