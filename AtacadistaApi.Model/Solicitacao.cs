using AtacadistaApi.Util.Enum;
using System.Collections.Generic;

namespace AtacadistaApi.Model
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }

        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
