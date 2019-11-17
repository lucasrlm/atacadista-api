using AtacadistaApi.Model;
using AtacadistaApi.Model.Orcamento;

namespace AtacadistaApi.Servicos.Interface
{
    public interface ILojistaApi
    {
        RetornoBase CriarOrcamento(Orcamento orcamento);
    }
}
