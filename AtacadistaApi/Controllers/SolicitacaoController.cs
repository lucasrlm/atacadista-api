using AtacadistaApi.Model.Solicitacao;
using AtacadistaApi.Negocio.Interface;
using AtacadistaApi.Util.Enum;
using Microsoft.AspNetCore.Mvc;

namespace AtacadistaApi.Controllers
{
    [Route("api/solicitacao")]
    [ApiController]
    public class SolicitacaoController : ControllerBase
    {
        private readonly ISolicitacaoNegocio _solicitacaoNegocio;

        public SolicitacaoController(ISolicitacaoNegocio solicitacaoNegocio)
        {
            _solicitacaoNegocio = solicitacaoNegocio;
        }

        [HttpPost]
        public ActionResult Post([FromBody]SolicitacaoRequisicao solicitacao)
        {
            var retorno = _solicitacaoNegocio.CriarSolicitacao(solicitacao);
            return Ok(retorno);
        }

        [HttpPut("{solicitacaoId}")]
        public ActionResult Put(int solicitacaoId, [FromBody]SolicitacaoStatus solicitacaoStatus)
        {
            _solicitacaoNegocio.AlterarSolicitacao(solicitacaoId, solicitacaoStatus);
            return Ok();
        }
    }
}
