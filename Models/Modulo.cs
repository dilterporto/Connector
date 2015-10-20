using System.Collections.Generic;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class Modulo
    {
        public long Id { get; set; }

        public string Caminho { get; set; }
        public string Descricao { get; set; }
        public IList<GrupoFuncionalidade> GruposFuncionalidades { get; set; }
    }
}
