using System;
using System.Linq;
using System.Collections.Generic;
using Unio.Nucleos.AccessControl.Conector.Models;
using System.Xml.Serialization;
using System.Text;  
using System.IO;
using System.Security.Claims;
using ServiceStack.Text;

namespace Unio.Nucleos.AccessControl.Conector.Client
{
    public static class ClaimsPrincipalExtensions
    {
        public static dynamic GetAcessos(this ClaimsPrincipal principal)
        {
            var acessos = principal.Claims.FirstOrDefault(x => x.Type == Constants.ClaimTypes.Acessos);
            return JsonSerializer.DeserializeFromString<dynamic>(acessos.Value);            
        }

        //public static bool HasFuncao(this ClaimsPrincipal principal, string funcao)
        //{
        //    var has = false;

        //    var acessos = principal.GetAcessos().ToList();
        //    acessos.ForEach(x =>
        //    {
        //        x.Modulos.ToList().ForEach(m =>
        //        {
        //            m.GruposFuncionalidade.ToList().ForEach(g =>
        //            {
        //                g.Funcionalidades.ToList().ForEach(fc =>
        //                {
        //                    fc.Funcoes.ToList().ForEach(f =>
        //                    {
        //                        if (f.Descricao == funcao)
        //                            has = true;
        //                    });
        //                });
        //            });
        //        });
        //    });

        //    return has;
        //}
    }
}

namespace Unio.Nucleos.AccessControl.Conector.Client
{
    public static class Constants
    {
        public class ClaimTypes
        {
            public const string Acessos = "acessos";
        }
    }
}