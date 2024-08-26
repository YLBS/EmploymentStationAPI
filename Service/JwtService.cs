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
        private readonly sitedataContext _sitedatadb;
        public JwtService(IOptions<JWTTokenOptions> options,sitedataContext sitedata)
        {
            this._jwtTokenOptions = options.Value;
            this._sitedatadb = sitedata;
        }
       

        public async Task<JwtModels> VerificationLogin(string userName, string psw)
        {
            JwtModels jwtMdel =new JwtModels();
            var userInfo= await _sitedatadb.Set<ZphAdminUser>().Where(e => e.UserName == userName && e.PassWord==psw).FirstOrDefaultAsync();
           
            if (userInfo != null)
            {
                
                jwtMdel.Id = userInfo.ZphAdminId;
                jwtMdel.Title = userInfo.Title;
            }
            
            return jwtMdel;

        }
    }
}
