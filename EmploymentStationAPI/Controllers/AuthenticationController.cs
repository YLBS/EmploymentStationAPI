using Component;
using EmploymentStationAPI.JWT;
using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceStack.Script;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 登录认证
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly ITokenService _tokenService;
        public AuthenticationController(IJwtService jwtService, ITokenService tokenService)
        {
            _jwtService = jwtService;
            _tokenService = tokenService;
        }
        /// <summary>
        /// 验证账号密码，返回token
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="psw"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CheckPsw(string userName,string psw)
        {
            var jwt = await _jwtService.VerificationLogin(userName, psw);
            if (jwt.Id!=0)
            {
                var tokens = await _tokenService.IssueTokenAsync(jwt.Id);
                return Ok(new{token=tokens.AccessToken });
            }
            return BadRequest("账号或密码错误");
        }
        /// <summary>
        /// 刷新token
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> RefreshToken()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (string.IsNullOrEmpty(token))
            {
                return Ok(new { Code = 401, Msg = "Token已丢失" });
            }
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != null)  //Token未过期，重新生成token返回
            {
                var tokens = await _tokenService.IssueTokenAsync(Convert.ToInt32(userId));
                return Ok(new
                {
                    token = tokens.AccessToken,
                    Expires = tokens.Expires
                });
            }
            //解析过期token
            var jwtSecurityToken = await _tokenService.ReadJwtToken(token);
            if (jwtSecurityToken != null)
            {
                userId = jwtSecurityToken.Claims
                    .FirstOrDefault(s => s.Type == "UserId")?.Value;
                var i = Convert.ToInt32(jwtSecurityToken.Claims
                    .FirstOrDefault(s => s.Type == "refreshTokenExpires")?.Value);
                var j = Convert.ToInt32(DateTime.Now.AddDays(1).ToUnixTimeStampSecond().ToString());
                if (i > j) 
                {
                    var tokens = await _tokenService.IssueTokenAsync(Convert.ToInt32(userId));
                    return Ok(new
                    {
                        Code=200,Data=new
                        {
                            token = tokens.AccessToken,
                            Expires = tokens.Expires
                        }
                        
                    });
                }
                else
                {
                    return Ok(new{Code=401,Msg= "已超过刷新时间，请重新登录" });
                }
            }
            return Ok(new { Code = 401, Msg = "token验证失败，请重新登录" });
        }
    }
}
