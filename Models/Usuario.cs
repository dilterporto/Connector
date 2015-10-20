using System.Collections.Generic;

namespace Unio.Nucleos.AccessControl.Conector.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }
        public string TipoAutenticacao { get; set; }
        public LocalFisico LocalFisico { get; set; }
        public IList<UnidadeUsuario> Unidades { get; set; }
        public IList<AcessoUsuario> Acessos { get; set; }
        public string TipoUsuario { get; set; }
    }
}