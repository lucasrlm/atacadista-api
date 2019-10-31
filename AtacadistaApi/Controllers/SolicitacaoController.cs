﻿using AtacadistaApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace AtacadistaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitacaoController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]Solicitacao solicitacao)
        {
            return Ok(solicitacao);
        }

        // PUT api/values/5
        [HttpPut("{solicitacaoId}")]
        public ActionResult Put(int solicitacaoId, [FromBody]Solicitacao solicitacao)
        {
            return Ok(solicitacao);
        }
    }
}