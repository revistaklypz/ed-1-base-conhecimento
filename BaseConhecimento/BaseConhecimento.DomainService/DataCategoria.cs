using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace BaseConhecimento.DomainService
{
    public class DataCategoria : IDataCategoria
    {
        public DataCategoria(DbConnection connection)
        {
            Connection = connection;
        }

        public DbConnection Connection { get; }

        public ClienteCategoria ObterCategoria(string apelido) => Connection.QueryFirstOrDefault<ClienteCategoria>(SQLCategoria.GetApelido, new { apelido });

        public ClienteCategoria ObterCategoria(Guid id) => throw new NotImplementedException();

        public IEnumerable<ClienteCategoria> ObterCategorias() => Connection.Query<ClienteCategoria>(SQLCategoria.Get);

        public IEnumerable<ClienteCategoria> ObterCategorias(string filtro) => Connection.Query<ClienteCategoria>(SQLCategoria.GetFiltro, new { filtro });
    }
}
