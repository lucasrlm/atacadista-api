using AtacadistaApi.Model;
using AtacadistaApi.Model.Orcamento;

namespace AtacadistaApi.AcessoDados.Interface
{
    public interface IOrcamentoRepositorio
    {
        RetornoBase CriarOrcamento(OrcamentoRequisicao orcamentoRequisicao);
    }
}
