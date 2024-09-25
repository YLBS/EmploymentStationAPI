

using Iservice;
using Microsoft.Extensions.Caching.Memory;
using Models;

namespace EmploymentStationAPI.Module
{
    public static class Configs
    {
        private const string TenantKey = "TenantConnectionString"; 
        private static IMemoryCache _cache;

        public static void Initialize(IMemoryCache cache)
        {
            _cache = cache;
        }

        public static string GetConnectionString(this HttpContext context)
        {
          
            try
            {
                if (context.Request.Path.StartsWithSegments("/api/Home/GetStationList"))
                {
                    return "Goodjob_ThirdParty";
                }
                if (!_cache.TryGetValue(TenantKey, out List<OutDicModels> list))
                {
                    var dic = context.RequestServices.GetService<IOutDicService>();
                    list = dic.GetDbConnection();
                    _cache.Set(TenantKey, list, DateTime.Now.AddDays(1));
                }

                string tenantId = context.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");

                int belongType = Convert.ToInt32(tenantId);

                string s = list.Where(s => s.Id == belongType).Select(s => s.Name).Single();
                
                return s;
                
            }
            catch (Exception e)
            {
                string logPath = "path/logfile.txt";
                Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                using (StreamWriter sw = File.AppendText(logPath))
                {
                    sw.WriteLine("数据库连接异常 at: " + DateTime.Now);
                    sw.WriteLine(e.Message);
                }
                throw;
            }

        }

        //private static IDictionary<string, string> Dictionarys = new Dictionary<string, string>
        //{
        //    {"1","dagang"},
        //    {"2","nansha"},
        //    {"4","huangge"},
        //    {"5","nancun"},
        //};
        
    }
}
