using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace BaseConhecimento.DomainService
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public CategoriaRepository(DbConnection connection)
        {
            Connection = connection;
        }

        public DbConnection Connection { get; }

        public ClienteCategoria ObterCategoria(string apelido)
        {
            return Connection.QueryFirstOrDefault<ClienteCategoria>(SQLCategoria.GetApelido, new { apelido });
        }

        public ClienteCategoria ObterCategoria(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteCategoria> ObterCategorias()
        {
            return Connection.Query<ClienteCategoria>(SQLCategoria.Get);
        }

        public IEnumerable<ClienteCategoria> ObterCategorias(string filtro)
        {
            return Connection.Query<ClienteCategoria>(SQLCategoria.GetFiltro, new { filtro });
        }
    }
}
