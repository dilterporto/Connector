using System;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class UnidadeUsuario
    {
        public long Id { get; set; }
        public UnidadeOrganizacional UnidadeOrganizacional { get; set; }
        public bool IsResponsavel { get; set; }
    }
}