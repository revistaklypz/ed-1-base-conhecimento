﻿using BaseConhecimento.Domain.Model;
using System.Collections.Generic;

namespace BaseConhecimento.Domain
{

    public interface IClienteConhecimento
    {
        IEnumerable<ClienteConhecimento> ObterConhecimentos(string categoriaApelido);
        IEnumerable<ClienteConhecimento> ObterConhecimentos(string filtro, string categoriaApelido);
        ClienteConhecimento ObterConhecimento(string apelido);
    }
}
