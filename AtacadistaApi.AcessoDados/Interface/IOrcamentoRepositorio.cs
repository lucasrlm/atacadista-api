using AtacadistaApi.Model.Orcamento;

namespace AtacadistaApi.AcessoDados.Interface
{
    public interface IOrcamentoRepositorio
    {
        int CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
