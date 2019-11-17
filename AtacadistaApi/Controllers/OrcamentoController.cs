using AtacadistaApi.Model.Orcamento;
using AtacadistaApi.Negocio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AtacadistaApi.Controllers
{
    [Route("api/orcamento")]
    [ApiController]
    public class OrcamentoController : ControllerBase
    {
        private readonly IOrcamentoNegocio _orcamentoNegocio;

        public OrcamentoController(IOrcamentoNegocio orcamentoNegocio)
        {
            _orcamentoNegocio = orcamentoNegocio;
        }

        [HttpPost]
        public ActionResult Post([FromBody]OrcamentoRequisicao orcamento)
        {
            var retorno = _orcamentoNegocio.CriarOrcamento(orcamento);
            return Ok(retorno);
        }
    }
}
