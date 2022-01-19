using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConhecimento.Domain.Model
{
    public class Categoria
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime ModificadoEm { get; set; } = DateTime.Now;
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Descricao { get; set; }
    }
}
