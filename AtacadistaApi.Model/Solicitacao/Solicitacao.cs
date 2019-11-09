using AtacadistaApi.Util.Enum;
using System.Collections.Generic;

namespace AtacadistaApi.Model.Solicitacao
{
    public class Solicitacao
    {
        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
