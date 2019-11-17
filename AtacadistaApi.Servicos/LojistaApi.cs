using AtacadistaApi.Model.Orcamento;
using AtacadistaApi.Servicos.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace AtacadistaApi.Servicos
{
    public class LojistaApi : ILojistaApi
    {
        private readonly IConfiguration _configuracao;

        private readonly HttpClient _clienteHttp;

        public LojistaApi(IConfiguration configuracao)
        {
            _configuracao = configuracao;
            _clienteHttp = new HttpClient()
            {
                BaseAddress = new Uri(_configuracao.GetSection("Apis:LojistaApi").Value)
            };
        }

        public int CriarOrcamento(Orcamento orcamento)
        {
            var json = JsonConvert.SerializeObject(orcamento);

            var response = _clienteHttp.PostAsync("", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                var contents = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<int>(contents);
            }
            else
            {
                throw new Exception("Erro na chamada da API de lojista.");
            }
        }
    }
}
