using Iservice;
using Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;
using Entity.GoodBoss;
using Microsoft.EntityFrameworkCore;
using Entity.Sitedata;

namespace Service
{
    public class JwtService : IJwtService
    {
        private JWTTokenOptions _jwtTokenOptions;
        //private readonly GoodBossContext _bossContext;
        private readonly sitedataContext _sitedatadb;
        public JwtService(IOptions<JWTTokenOptions> options,sitedataContext sitedata)
        {
            this._jwtTokenOptions = options.Value;
            //this._bossContext = goodBoss;
            this._sitedatadb = sitedata;
        }
        /// <summary>
        /// 生成Token就2个步骤：
        /// 1  组装信息
        /// 2  加密---JWT依赖一系列信息
        /// </summary>
        /// <param name="jwtMdel"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string GetToken(JwtModels jwtMdel)
        {
            var claims = new[]
            {
                new Claim("Name", jwtMdel.EplName),
                new Claim("Id", jwtMdel.Id.ToString()),
                #region 为授权添加
                //new Claim(ClaimTypes.Role,jwtMdel.Role),
                #endregion
 
            };
            /*
             在 ASP.NET Core 中，您可以使用 SymmetricSecurityKey 类来表示对称加密算法的密钥。
            对称加密算法使用相同的密钥用于加密和解密数据，因此该密钥必须保密并且仅在通信双方之间共享。
            在您提供的代码中，this._JWTTokenOptions.SecurityKey 是用于创建 JWT 签名凭据的密钥字符串。
            Encoding.UTF8.GetBytes 方法将该字符串转换为字节数组，然后使用该字节数组创建一个 SymmetricSecurityKey 对象。
            在 JWT 身份验证中，该密钥用于加密和解密 JWT 数据。
            // 生成Token的密钥
             */
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtTokenOptions.SecurityKey));
            /*
             在 ASP.NET Core 中，您可以使用 SigningCredentials 类创建用于 JWT（JSON Web Token）身份验证的签名凭据对象。
            JWT 是一种开放标准，用于在各种应用程序和服务之间安全地传输信息。JWT 由三部分组成：头部、载荷和签名。
            在您提供的代码中，key 是一个 SymmetricSecurityKey 对象，用于存储加密和解密 JWT 数据的密钥值。
            SecurityAlgorithms.HmacSha256 表示使用 HMAC-SHA256 算法进行签名。SigningCredentials 类将这些参数组合在一起，
            创建用于 JWT 签名的签名凭据对象。
            // 生成Token的签名证书
             */
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            /**
             * Claims (Payload)
                Claims 部分包含了一些跟这个 token 有关的重要信息。 JWT 标准规定了一些字段，下面节选一些字段:
                iss: The issuer of the token，token 是给谁的
                sub: The subject of the token，token 主题
                exp: Expiration Time。 token 过期时间，Unix 时间戳格式
                iat: Issued At。 token 创建时间， Unix 时间戳格式
                jti: JWT ID。针对当前 token 的唯一标识
                除了规定的字段外，可以包含其他任何 JSON 兼容的字段。
            // 创建Token
             * */
            var token = new JwtSecurityToken(
                issuer: this._jwtTokenOptions.Isuser,
                audience: this._jwtTokenOptions.Audience,
                claims: claims,
                expires: DateTime.Now.AddSeconds(60 * 60 * 24),//60分钟有效期
                notBefore: DateTime.Now,//立即生效  DateTime.Now.AddMilliseconds(30),//30s后有效
                signingCredentials: creds);
            // 生成Token字符串
            string returnToken = new JwtSecurityTokenHandler().WriteToken(token);
            return returnToken;
        }

        public string[] ValidateToken(string token)
        {
            string[] strings = new string[2];
            if (token != null)
            {
                try
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._jwtTokenOptions.SecurityKey));
                    //证书
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var jwtHandler = new JwtSecurityTokenHandler();
                    var claimsPrincipal = jwtHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        IssuerSigningKey = key,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                    }, out _);
                    foreach (var claim in claimsPrincipal.Claims)
                    {
                        if (claim.Type == "Name")
                        {
                            strings[0] = claim.Value;
                        }
                        if (claim.Type == "Id")
                        {
                            strings[1] = claim.Value;
                        }
                    }
                    string? id = claimsPrincipal.Claims.SingleOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"错误: {e.Message}");
                    strings[0] = "token过期";
                    strings[1] = "0";
                    //throw;
                }

            }
            return strings;
            throw new NotImplementedException();
        }

        public async Task<JwtModels> VerificationLogin(string userName, string psw)
        {
            JwtModels jwtMdel =new JwtModels();
            var userInfo= await _sitedatadb.Set<ZphAdminUser>().Where(e => e.UserName == userName && e.PassWord==psw).FirstOrDefaultAsync();
            //var userInfo1= await  _bossContext.Set<ErmEmployee>().Where( e=>e.UserName==userName).FirstOrDefaultAsync();
            if (userInfo != null)
            {
                //string str;
                //using (var md5 = MD5.Create())
                //{
                //    byte[] inputBytes = Encoding.UTF8.GetBytes(psw);
                //    byte[] hashBytes = md5.ComputeHash(inputBytes);

                //    // Convert byte array to a string
                //    StringBuilder sb = new StringBuilder();
                //    for (int i = 0; i < hashBytes.Length; i++)
                //    {
                //        sb.Append(hashBytes[i].ToString("X2")); // Convert to hexadecimal
                //    }
                //    str= sb.ToString().ToLower();
                //    //var result = md5.ComputeHash(Encoding.UTF8.GetBytes(userInfo.UserPwd));
                //    //var strResult = BitConverter.ToString(result);
                //    //str=strResult.Replace("-", "").ToUpper();
                //}

                //if (str.Equals(userInfo.UserPwd))
                //{
                //    jwtMdel.Id = userInfo.EplId;
                //    jwtMdel.EplName=userInfo.EplName;
                //}
                jwtMdel.Id = userInfo.ZphAdminId;
                jwtMdel.EplName = userInfo.Title;
                jwtMdel.AffiliatedUnit = userInfo.AffiliatedUnit;
            }
            
            return jwtMdel;

        }
    }
}
