using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iservice
{
    public interface IJwtService
    {
        /// <summary>
        /// 验证码密码
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="psw"></param>
        /// <param name="tf"></param>
        /// <returns></returns>
        Task<JwtModels> VerificationLogin(string userName, string psw);
        /// <summary>
        /// 生成Token
        /// </summary>
        /// <param name="jwtModel"></param>
        /// <returns></returns>
        string GetToken(JwtModels jwtModel);
        /// <summary>
        /// 解析Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        string[] ValidateToken(string token);
    }
}
