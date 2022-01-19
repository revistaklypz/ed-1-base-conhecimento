using System;

namespace BaseConhecimento.Domain.Model
{
    public class ClienteConhecimento
    {
        public DateTime ModificadoEm { get; set; } = DateTime.Now;
        public string Titulo { get; set; }
        public string Apelido { get; set; }
        public string Descricao { get; set; }
        public ClienteCategoria Categoria { get; set; }

    }
}
