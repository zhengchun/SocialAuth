using Microsoft.AspNetCore.Http;
using Yamool.AspNetCore.Authentication.Tencent;

namespace Microsoft.AspNetCore.Builder
{
    public class TencentOptions : OAuthOptions
    {
        public TencentOptions()
        {
            AuthenticationScheme = TencentDefaults.AuthenticationScheme;
            DisplayName = AuthenticationScheme;
            ClaimsIssuer = TencentDefaults.Issuer;
            CallbackPath = new PathString(TencentDefaults.CallbackPath);

            AuthorizationEndpoint = TencentDefaults.AuthorizationEndpoint;
            TokenEndpoint = TencentDefaults.TokenEndpoint;
            OpenIdEndpoint = TencentDefaults.OpenIdEndpoint;
            UserInformationEndpoint = TencentDefaults.UserInformationEndpoint;

            Scope.Add("get_user_info");
        }

        /// <summary>
        /// The APP ID.
        /// </summary>
        public string AppId
        {
            get
            {
                return ClientId;
            }
            set
            {
                ClientId = value;
            }
        }

        /// <summary>
        /// The app secret key for APP.
        /// </summary>
        public string AppKey
        {
            get
            {
                return ClientSecret;
            }
            set
            {
                ClientSecret = value;
            }
        }

        /// <summary>
        /// The endpoint for received an openid.
        /// </summary>
        public string OpenIdEndpoint
        {
            get;
            set;
        }
    }
}
