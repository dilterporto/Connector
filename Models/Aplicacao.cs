using System.Collections.Generic;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class Aplicacao
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Modulo> Modulos { get; set; }
    }
}
