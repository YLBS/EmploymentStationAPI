using Microsoft.IdentityModel.Tokens;
using Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
namespace EmploymentStationAPI.Module
{
    public class JwtTokenValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private JWTTokenOptions _jwtTokenOptions;

        public JwtTokenValidationMiddleware(RequestDelegate next, IOptions<JWTTokenOptions> options)
        {
            this._jwtTokenOptions = options.Value;
            _next = next;
        }

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
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtTokenOptions.SecurityKey));//Encoding.UTF8.GetBytes("your_secret_key"); // Replace with your actual secret key
            var validations = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _jwtTokenOptions.Isuser,
                ValidAudience = _jwtTokenOptions.Audience,
                IssuerSigningKey = key
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validations, out var validatedToken);
                return principal;
            }
            catch (SecurityTokenExpiredException)
            {
                // Token has expired
                return null;
            }
            catch (Exception e)//SecurityTokenInvalidException
            {
                // Token is invalid
                return null;
            }
        }
    }
}
