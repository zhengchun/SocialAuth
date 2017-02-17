using System;
using Microsoft.Extensions.Options;
using Yamool.AspNetCore.Authentication.Tencent;

namespace Microsoft.AspNetCore.Builder
{
    public static class TencentAppBuilderExtensions
    {
        /// <summary>
        ///  Adds the <see cref="TencentMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>,
        ///  which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseQQAuthentication(this IApplicationBuilder app, TencentOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
            return app.UseMiddleware<TencentMiddleware>(Options.Create(options));
        }

        /// <summary>
        /// Adds the <see cref="TencentMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>,
        /// which enables QQ authentication capabilities.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseQQAuthentication(this IApplicationBuilder app, Action<TencentOptions> configuration)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            var options = new TencentOptions();
            configuration(options);

            return app.UseMiddleware<TencentMiddleware>(Options.Create(options));
        }
    }
}
