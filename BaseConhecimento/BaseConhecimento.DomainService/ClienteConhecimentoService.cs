using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using System.Collections.Generic;

namespace BaseConhecimento.DomainService
{
    public class ClienteConhecimentoService : IClienteConhecimento
    {
        public ClienteConhecimentoService(IDataConhecimento repository)
        {
            Repository = repository;
        }

        public IDataConhecimento Repository { get; }

        public ClienteConhecimento ObterConhecimento(string apelido) => Repository.ObterConhecimento(apelido);

        public IEnumerable<ClienteConhecimento> ObterConhecimentos(string categoriaApelido) => Repository.ObterConhecimentos(categoriaApelido);

        public IEnumerable<ClienteConhecimento> ObterConhecimentos(string filtro, string categoriaApelido) => Repository.ObterConhecimentos(filtro, categoriaApelido);
    }
}
