namespace EmploymentStationAPI.Module
{
    public static class Configs
    {
        private const string TenantKey = "TenantConnectionString";
        //private static IConfigurationRoot Configuration { get; set; }
        //static Configs()
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        //    Configuration = builder.Build();
        //}
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

        #region 注释掉

        /// <summary>
        /// 根据租户ID选择合适的连接字符串
        /// </summary>
        /// <param name="tenantId"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        private static string GetConnectionStringForTenant(string tenantId)
        {
            // 这里应该是根据租户ID获取对应连接字符串的逻辑
            // 例如，从配置文件或服务获取
            switch (tenantId)
            {
                case "tenant1":
                    return "YourConnectionStringForTenant1";
                case "tenant2":
                    return "YourConnectionStringForTenant2";
                // 其他租户
                default:
                    throw new InvalidOperationException("Invalid tenant ID.");
            }
        }

        #endregion


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
            {"dg","dagang"},
            {"hg","huangge"},
            {"ns","nansha"},
        };
        
    }
}
