using Microsoft.AspNet.Builder;

namespace Unio.Nucleos.AccessControl.Conector.Configuracao
{
    public static class ApplicationBuilderExtensions
    {
        #region Methods

        public static void UseAccessControl(this IApplicationBuilder builder, string clientId, string autorityHost, string redirectUri)
        {
            builder.UseIdentityServer(clientId, autorityHost, redirectUri);
        }


        public static void UseIdentityServer(this IApplicationBuilder builder, string clientId, string autorityHost, string redirectUri)
        {
            builder.UseOpenIdConnectAuthentication(options =>
            {                
                options.Authority = string.Format("{0}/identity", autorityHost);
                options.ClientId = clientId;
                options.RedirectUri = redirectUri;
                options.ResponseType = "id_token token";
                options.SignInScheme = "Cookies";
                options.Scope = "openid profile email";
                options.AutomaticAuthentication = true;

            });
        }

        #endregion
    }
}