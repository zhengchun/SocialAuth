using Microsoft.AspNetCore.Http;
using Yamool.AspNetCore.Authentication.WeChat;

namespace Microsoft.AspNetCore.Builder
{
    public class WeChatOptions : OAuthOptions
    {
        public WeChatOptions()
        {
            AuthenticationScheme = WeChatDefaults.AuthenticationScheme;
            DisplayName = AuthenticationScheme;
            ClaimsIssuer = WeChatDefaults.Issuer;
            CallbackPath = new PathString(WeChatDefaults.CallbackPath);

            AuthorizationEndpoint = WeChatDefaults.AuthorizationEndpoint;
            TokenEndpoint = WeChatDefaults.TokenEndpoint;
            UserInformationEndpoint = WeChatDefaults.UserInformationEndpoint;

            Scope.Add("snsapi_login");
            Scope.Add("snsapi_userinfo");
        }

        /// <summary>
        /// The App Id.
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
        /// The App Secret.
        /// </summary>
        public string AppSecret
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
    }
}
