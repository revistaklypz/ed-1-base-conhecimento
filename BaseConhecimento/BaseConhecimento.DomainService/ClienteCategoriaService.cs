using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using System.Collections.Generic;

namespace BaseConhecimento.DomainService
{
    public class ClienteCategoriaService : IClienteCategoria
    {
        public ClienteCategoriaService(ICategoriaRepository repository)
        {
            Repository = repository;
        }

        public ICategoriaRepository Repository { get; }

        public ClienteCategoria ObterCategoria(string apelido) => Repository.ObterCategoria(apelido);

        public IEnumerable<ClienteCategoria> ObterCategorias() => Repository.ObterCategorias();

        public IEnumerable<ClienteCategoria> ObterCategorias(string filtro) => Repository.ObterCategorias(filtro);
    }
    public class ClienteConhecimentoService : IClienteConhecimento
    {
        public ClienteConhecimentoService(IConhecimentoRepository repository)
        {
            Repository = repository;
        }

        public IConhecimentoRepository Repository { get; }

        public ClienteConhecimento ObterCategoria(string apelido)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClienteConhecimento> ObterCategorias(string categoriaApelido)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ClienteConhecimento> ObterCategorias(string filtro, string categoriaApelido)
        {
            throw new System.NotImplementedException();
        }
    }
}
