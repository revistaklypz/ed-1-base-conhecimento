using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BaseConhecimento.App.Controller.Cliente
{
    [Route("api/cliente/[controller]")]
    [ApiController]
    public class ConhecimentoController : ControllerBase
    {
        public ConhecimentoController(IDataConhecimento domain)
        {
            Domain = domain;
        }

        public IDataConhecimento Domain { get; }

        [HttpGet("{apelido}")]
        public ClienteConhecimento Get(string apelido) => Domain.ObterConhecimento(apelido);

        [HttpGet]
        public IEnumerable<ClienteConhecimento> GetList(string q = null, string cat = null) => string.IsNullOrEmpty(q) ? Domain.ObterConhecimentos(cat) : Domain.ObterConhecimentos(q, cat);
    }
}
