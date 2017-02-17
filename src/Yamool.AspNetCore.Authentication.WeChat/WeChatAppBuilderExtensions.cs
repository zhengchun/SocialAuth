using System;
using Microsoft.Extensions.Options;
using Yamool.AspNetCore.Authentication.WeChat;

namespace Microsoft.AspNetCore.Builder
{
    public static class WeChatAppBuilderExtensions
    {
        /// <summary>
        ///  Adds the <see cref="WeChatMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>,
        ///  which enables Weibo authentication capabilities.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseWeChatAuthentication(this IApplicationBuilder app, WeChatOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
            return app.UseMiddleware<WeChatMiddleware>(Options.Create(options));
        }

        /// <summary>
        /// Adds the <see cref="WeChatMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>,
        /// which enables Weibo authentication capabilities.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseWeChatAuthentication(this IApplicationBuilder app, Action<WeChatOptions> configuration)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var options = new WeChatOptions();
            configuration(options);

            return app.UseMiddleware<WeChatMiddleware>(Options.Create(options));
        }
    }
}
