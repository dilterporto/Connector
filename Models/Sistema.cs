using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Unio.Nucleos.AccessControl.Conector.Models
{    
    public class Sistema
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
        public string Chave { get; set; }        
        public IEnumerable<Funcionalidade> Funcionalidades { get; set; }
        public IList<Modulo> Modulos { get; set; }
    }
}