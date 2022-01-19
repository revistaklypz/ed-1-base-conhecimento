using BaseConhecimento.Domain.Model;
using System.Collections;
using System.Collections.Generic;

namespace BaseConhecimento.Domain
{
    public interface IClienteCategoria
    {
        IEnumerable<ClienteCategoria> ObterCategorias();
        IEnumerable<ClienteCategoria> ObterCategorias(string filtro);
        ClienteCategoria ObterCategoria(string apelido);
    }
}
