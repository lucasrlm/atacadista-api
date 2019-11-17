using AtacadistaApi.Model.Orcamento;

namespace AtacadistaApi.Negocio.Interface
{
    public interface IOrcamentoNegocio
    {
        int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
