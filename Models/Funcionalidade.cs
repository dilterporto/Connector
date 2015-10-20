using System;
using System.Collections.Generic;
using System.Linq;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class Funcionalidade
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string TagIdentificacao { get; set; }
        public Funcionalidade FuncionalidadeRaiz { get; set; }

        public IList<Funcionalidade> Funcionalidades { get; set; }
        public IList<Funcao> Funcoes { get; set; }
        public Sistema Sistema { get; set; }
    }
}