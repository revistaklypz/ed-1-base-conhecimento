using BaseConhecimento.Domain;
using BaseConhecimento.Domain.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace BaseConhecimento.DomainService
{
    public class DataConhecimento : IDataConhecimento
    {
        public DataConhecimento(DbConnection connection)
        {
            Connection = connection;
        }

        public DbConnection Connection { get; }


        private ClienteConhecimento ConvertQuery(Conhecimento con, ClienteCategoria cat)
        {
            if (con is null)
            {
                return null;
            }

            if (cat is null)
            {
                return null;
            }

            ClienteConhecimento _result = new ClienteConhecimento
            {
                Apelido = con.Apelido,
                Descricao = con.Descricao,
                Titulo = con.Titulo,
                ModificadoEm = con.ModificadoEm,
                Categoria = new ClienteCategoria
                {
                    Apelido = cat.Apelido,
                    Descricao = cat.Descricao,
                    Nome = cat.Nome,
                    NumeroConhecimentos = cat.NumeroConhecimentos
                }
            };

            return _result;
        }

        public ClienteConhecimento ObterConhecimento(string apelido) => Connection.Query<Conhecimento, ClienteCategoria, ClienteConhecimento>(SQLConhecimento.GetApelido, ConvertQuery, new { apelido }).Where(p => p != null).FirstOrDefault();

        public IEnumerable<ClienteConhecimento> ObterConhecimentos(string categoriaApelido) => Connection.Query<Conhecimento, ClienteCategoria, ClienteConhecimento>(SQLConhecimento.GetFiltro, ConvertQuery, new
        {
            filtro = (string)null,
            categoriaApelido
        }).Where(p => p != null);

        public IEnumerable<ClienteConhecimento> ObterConhecimentos(string filtro, string categoriaApelido) => Connection.Query<Conhecimento, ClienteCategoria, ClienteConhecimento>(SQLConhecimento.GetFiltro, ConvertQuery, new
        {
            filtro,
            categoriaApelido
        }).Where(p => p != null);

        public IEnumerable<ClienteConhecimento> ObterConhecimentos() => Connection.Query<Conhecimento, ClienteCategoria, ClienteConhecimento>(SQLConhecimento.GetList, ConvertQuery).Where(p => p != null);
    }
}
