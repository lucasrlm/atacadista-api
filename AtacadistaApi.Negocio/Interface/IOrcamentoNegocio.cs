using AtacadistaApi.Model;
using AtacadistaApi.Model.Orcamento;

namespace AtacadistaApi.Negocio.Interface
{
    public interface IOrcamentoNegocio
    {
        RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
