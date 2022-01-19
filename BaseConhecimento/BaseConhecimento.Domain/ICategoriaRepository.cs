using BaseConhecimento.Domain.Model;
using System;
using System.Collections.Generic;

namespace BaseConhecimento.Domain
{
    public interface ICategoriaRepository
    {
        IEnumerable<ClienteCategoria> ObterCategorias();
        IEnumerable<ClienteCategoria> ObterCategorias(string filtro);
        ClienteCategoria ObterCategoria(string apelido);
        ClienteCategoria ObterCategoria(Guid id);
    }
}
