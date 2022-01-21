using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BaseConhecimento.App.Controller.Cliente
{
    [Route("api/cliente/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        public CategoriaController(IDataCategoria domain)
        {
            Domain = domain;
        }

        public IDataCategoria Domain { get; }

        [HttpGet("{apelido}")]
        public ClienteCategoria Get(string apelido) => Domain.ObterCategoria(apelido);

        [HttpGet]
        public IEnumerable<ClienteCategoria> GetList(string q = null) => string.IsNullOrEmpty(q) ? Domain.ObterCategorias() : Domain.ObterCategorias(q);
    }
}
