using System;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class AcessoUsuario
    {
        public long Id { get; set; }
        public Funcao Funcao { get; set; }
        public string PerfilAcesso { get; set; }
    }
}