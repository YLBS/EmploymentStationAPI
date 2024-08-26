namespace EmploymentStationAPI.Module
{
    public static class Configs
    {
        private const string TenantKey = "TenantConnectionString";
        public static IApplicationBuilder UseTenantDatabaseSelector(this IApplicationBuilder app)
        {
            return app.Use(async (context, next) =>
            {
                string tenantId = GetTenantIdFromRequest(context.Request);

                //string connectionString = GetConnectionStringForTenant(tenantId);

                // 存储在请求的Items集合中，以便后续使用
                context.Request.HttpContext.Items[TenantKey] = tenantId;
                
                await next();
            });
        }
        /// <summary>
        /// 返回与配置文件中数据库连接字符串的Key
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        private static string GetTenantIdFromRequest(HttpRequest request)
        {
            try
            {
                string ss = request.Headers["tenantId"].ToString().Replace("tenantId ", "");
                //string host = request.Host.Host;
                string str = Dictionarys[ss];
                
                return str;
            }
            catch (Exception e)
            {
                return "huangge";
            }
            
        }


        public static string GetConnectionString(this HttpContext context)
        {
            if (context.Items.TryGetValue(TenantKey, out object connectionStringObject))
            {
                return (string)connectionStringObject;
            }

            return "huangge";
            throw new InvalidOperationException("Connection string is not set for the current request.");
        }

        private static IDictionary<string, string> Dictionarys = new Dictionary<string, string>
        {
            {"1","dagang"},
            {"2","nansha"},
            {"4","huangge"},
            {"5","nancun"},
        };
        
    }
}
