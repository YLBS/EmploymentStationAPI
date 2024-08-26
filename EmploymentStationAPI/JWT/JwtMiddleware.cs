using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ServiceStack;
using ServiceStack.Text;

namespace EmploymentStationAPI.JWT
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly JwtAuthOptions _jwtAuthOptions;
        public JwtMiddleware(RequestDelegate next, Microsoft.Extensions.Options.IOptions<JwtAuthOptions> options)
        {
            _jwtAuthOptions = options.Value;
            _next = next;
        }
        /// <summary>
        /// 实行验证
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/api/Authentication"))
            {
                await _next(context);
                return;
            }

            var token = context.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Missing or invalid token.");
                return;
            }

            try
            {
                var principal = ValidateToken(token);
                if (principal == null)
                {
                    context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                    await context.Response.WriteAsync("Invalid token.");
                    return;
                }

                context.User = principal;
            }
            catch (SecurityTokenExpiredException)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Token has expired.");
                return;
            }

            await _next(context);
        }

        private ClaimsPrincipal ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtAuthOptions.SecurityKey));
            var validations = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _jwtAuthOptions.Issuer,
                ValidAudience = _jwtAuthOptions.Audience,
                IssuerSigningKey = key,
                ClockSkew = TimeSpan.Zero,//偏移，默认5分钟！！！
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validations, out var validatedToken);
                return principal;
            }
            catch (SecurityTokenExpiredException exception)
            {
                return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
