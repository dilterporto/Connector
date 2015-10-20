using System.Collections.Generic;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class GrupoFuncionalidade
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public IList<Funcionalidade> Funcionalidades { get; set; }

    }
}
