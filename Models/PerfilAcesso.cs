using System;
using System.Collections.Generic;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class PerfilAcesso
    {
        public IList<Funcao> Funcoes { get; set; }
        public string Descricao { get; set; }
        public bool Administrador { get; set; }
    }
}