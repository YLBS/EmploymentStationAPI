
namespace EmploymentStationAPI.JWT
{
    public class Token
    {
        /// <summary>
        /// 授权token
        /// </summary>
        public string? AccessToken { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime Expires { get; set; }
        
    }
}
