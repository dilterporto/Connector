using System;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class Funcao
    {
        public virtual long Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Funcionalidade Funcionalidade { get; set; }
        public string TagIdentificacao { get; set; }
    }
}