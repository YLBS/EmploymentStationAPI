using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Service
{
    public class ConnectSettings
    {
        public static string? ConnectionStr;
        public static string? BaseConnectionStr;
        private readonly IConfiguration _configuration;
        public ConnectSettings(IConfiguration configuration,string ip)
        {
            _configuration = configuration;
            ConnectionStr = configuration[ip];
            // _ConnectionString = _configuration["ConnectionItem"];
            BaseConnectionStr = configuration["ConnectionItem:BaseConnection"];
        }
        public static string ConnectionString
        {
            get
            {
                if (ConnectionStr == null)
                {
                    return "";
                }
                return ConnectionStr;
            }
        }
        public static string BoledataSqlConnection
        {
            get
            {
                if (BaseConnectionStr == null)
                {
                    return "";
                }
                return BaseConnectionStr;
            }
        }
    }
}
