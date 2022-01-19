using System;

namespace BaseConhecimento.Domain.Model
{
    public class Conhecimento
    {
        public Guid Id { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime ModificadoEm { get; set; } = DateTime.Now;
        public int CategoriaId { get; set; }
        public string Titulo { get; set; }
        public string Apelido { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public Categoria Categoria { get; set; }
    }
}
