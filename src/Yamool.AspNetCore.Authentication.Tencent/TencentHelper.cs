using Newtonsoft.Json.Linq;

namespace Yamool.AspNetCore.Authentication.Tencent
{
    public class TencentHelper
    {
        public static string GetNickname(JObject user) => user.Value<string>("nickname");

        public static string GetFigureUrl(JObject user) => user.Value<string>("figureurl");

        public static string GetFigureUrl50X50(JObject user) => user.Value<string>("figureurl_1");

        public static string GetFigureUrl100X100(JObject user) => user.Value<string>("figureurl_2");

        public static string GetFigureQQUrl40X40(JObject user) => user.Value<string>("figureurl_qq_1");

        public static string GetFigureQQUrl100X100(JObject user) => user.Value<string>("figureurl_qq_2");

        public static string GetGender(JObject user) => user.Value<string>("gender");
    }
}
