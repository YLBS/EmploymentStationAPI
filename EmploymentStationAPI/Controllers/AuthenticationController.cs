using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmploymentStationAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        public AuthenticationController(IJwtService jwtService)
        {
            _jwtService = jwtService;
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
            if (!string.IsNullOrEmpty(jwt.EplName))
            {
                string token = _jwtService.GetToken(jwt);
                return Ok(new
                {
                    token,
                    tenantId = jwt.AffiliatedUnit
                });
            }
            return BadRequest("账号或密码错误");


        }
    }
}
