using AtacadistaApi.AcessoDados.Interface;
using AtacadistaApi.Model.Orcamento;
using AtacadistaApi.Negocio.Interface;

namespace AtacadistaApi.Negocio
{
    public class OrcamentoNegocio : IOrcamentoNegocio
    {
        private readonly IOrcamentoRepositorio _lojistaRepositorio;

        public int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao)
        {
            return _lojistaRepositorio.CriarOrcamento(orcamentoRequisicao);
        }
    }
}
