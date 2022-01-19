using BaseConhecimento.Domain.Model;
using System.Collections.Generic;

namespace BaseConhecimento.Domain
{
    public interface IConhecimentoRepository
    {

    }

    public interface IClienteConhecimento
    {
        IEnumerable<ClienteConhecimento> ObterCategorias(string categoriaApelido);
        IEnumerable<ClienteConhecimento> ObterCategorias(string filtro, string categoriaApelido);
        ClienteConhecimento ObterCategoria(string apelido);
    }
}
