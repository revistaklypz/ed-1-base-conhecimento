using BaseConhecimento.Domain.Model;
using System.Collections.Generic;

namespace BaseConhecimento.Domain
{
    public interface IDataConhecimento
    {
        ClienteConhecimento ObterConhecimento(string apelido);
        IEnumerable<ClienteConhecimento> ObterConhecimentos(string categoriaApelido);
        IEnumerable<ClienteConhecimento> ObterConhecimentos(string filtro, string categoriaApelido);
        IEnumerable<ClienteConhecimento> ObterConhecimentos();
    }
}
