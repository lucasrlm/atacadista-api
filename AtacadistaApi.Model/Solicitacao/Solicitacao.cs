using AtacadistaApi.Util.Enum;
using System.Collections.Generic;

namespace AtacadistaApi.Model.Solicitacao
{
    public class Solicitacao
    {
        public int LojistaId { get; set; }

        public int AtacadistaId { get; set; }

        public SolicitacaoStatus Status { get; set; }

        public IEnumerable<PedidoProduto> PedidosProdutoSolicitacao { get; set; }
    }
}
