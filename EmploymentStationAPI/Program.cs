using EmploymentStationAPI.ExceptionFilter;
using Entity.Base;
using Entity.Goodjob;
using Iservice;
using Microsoft.EntityFrameworkCore;
using Service;
using System.Net;
using EmploymentStationAPI.Module;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using Entity.Goodjob_Other;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Models;
using Entity.Sitedata;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerUI;
using Component;
using ServiceStack;

var builder = WebApplication.CreateBuilder(args);

//跨域
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy",
        builder => builder
            .WithOrigins("http://zj.goodjob.cn", "http://jy.goodjob.cn")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
    );
    //options.AddPolicy("MyCorsPolicy",
    //    policy => policy
    //        .AllowAnyOrigin()
    //        .AllowAnyMethod()
    //        .AllowAnyHeader()
    //        .AllowCredentials()
    //    );
});
#region 全局异常过滤器

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ExceptionFilter>();
});
#endregion

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1", Description= "description." });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath,true);
    var xmlFile1 = "Models.xml";
    var xmlPath1 = Path.Combine(AppContext.BaseDirectory, xmlFile1);
    options.IncludeXmlComments(xmlPath1);
    #region Swagger配置支持请求头参数传递 
    options.AddSecurityDefinition("TenantId", new OpenApiSecurityScheme
    {
        Description = "输入tenantId",
        Name = "tenantId",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {   
            new OpenApiSecurityScheme
            {
                Reference =new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id ="TenantId"
                }
            },
            new string[]{ }
        }
    });

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "输入token,格式为 Bearer jwtToken",
        Name = "Authorization",
        //Name = "jwtToken",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        Scheme = JwtBearerDefaults.AuthenticationScheme
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {   
            new OpenApiSecurityScheme
            {
                Reference =new OpenApiReference()
                {
                    Type = ReferenceType.SecurityScheme,
                    Id ="Bearer"
                }
            },
            new string[]{ }
        }
    });

    #endregion
});


#region JWT鉴权授权

builder.Services.Configure<JWTTokenOptions>(builder.Configuration.GetSection("JWTTokenOptions"));

JWTTokenOptions tokenOptions = new JWTTokenOptions();//初始化
builder.Configuration.Bind("JWTTokenOptions", tokenOptions);//实现调用

//鉴权
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //JWT有一些默认的属性，就是给鉴权时就可以筛选了
            ValidateIssuer = true,//是否验证Issuer
            ValidateAudience = true,//是否验证Audience
            ValidateLifetime = false,//是否雅正失效时间
            ValidateIssuerSigningKey = true,//是否验证SecurityKey
            ValidAudience = tokenOptions.Audience,
            ValidIssuer = tokenOptions.Isuser,//Issuer,这两项和前面签发jwt的设置一致
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
        };
    });
//授权
builder.Services.AddAuthorization(options =>
{
    //要求有个角色字段 --- 指定Admin //[Authorize(Roles = "Admin")] //[Authorize(Policy = "AdminPolicy")]
    options.AddPolicy("AdminPolicy", policyBuilder => policyBuilder.RequireRole("Admin"));

    //要求用户信息里面必须有Role字段,他的信息必须是Admian  //[Authorize(Policy = "AssertionAdminPolicy")]
    options.AddPolicy("AssertionAdminPolicy", policyBuilder =>
            policyBuilder.RequireAssertion(context =>
                context.User.HasClaim(c => c.Type == ClaimTypes.Role)
                && context.User.Claims.First(c => c.Type.Equals(ClaimTypes.Role)).Value == "Admin")//Claim的Role是User
    );
});

#endregion



//builder.Services.AddScoped<DbContext, BaseDbContext>();
//builder.Services.AddScoped<DbContext, GoodjobContext>();
//builder.Services.AddScoped<DbContext, Goodjob_OtherContext>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOutDicService, OutDicService>();
builder.Services.AddTransient<IJwtService, JwtService>();
builder.Services.AddTransient<IJobService, JobService>();
builder.Services.AddTransient<ILiveAndZph, LiveAndZph>();
builder.Services.AddTransient<INewsInfoService, NewsInfoService>();

var mapper = AutoMapperConfig.ConfigureAutoMapper();
builder.Services.AddSingleton(mapper);
//builder.Services.AddAutoMapper(typeof(MappingProfile)); // 添加AutoMapper服务

builder.Services.AddHttpContextAccessor();

// 获取当前机器的IP地址
//var hostName = Dns.GetHostName();
//var ip = Dns.GetHostEntry(hostName).AddressList[0];

//判断是不是开发模式
var env = builder.Environment;
var isDevelopment = env.IsDevelopment();

#region 选择数据库

builder.Services.AddDbContext<BaseDbContext>((sp, options) =>
{
    string str = sp.GetService<IHttpContextAccessor>()?.HttpContext.GetConnectionString();
    if (string.IsNullOrEmpty(str))
        str = "huangge";
    if (isDevelopment)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
        var connectionString = configuration.GetConnectionString(str);
        options.UseSqlServer(connectionString);
    }
    else
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString(str);
        options.UseSqlServer(connectionString);
    }


});

#endregion

#region GoodJob 数据库

builder.Services.AddDbContext<GoodjobContext>(options =>
{
    if (isDevelopment)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
        var connectionString = configuration.GetConnectionString("JobConnection");
        options.UseSqlServer(connectionString);
    }
    else
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString("JobConnection");
        options.UseSqlServer(connectionString);
    }
});

#endregion

#region Goodjob_Other 数据库

builder.Services.AddDbContext<Goodjob_OtherContext>(options =>
{
    if (isDevelopment)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
        var connectionString = configuration.GetConnectionString("GoodjobOtherConnection");
        options.UseSqlServer(connectionString);
    }
    else
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString("GoodjobOtherConnection");
        options.UseSqlServer(connectionString);
    }
});

#endregion

#region GoodBoss 数据库
/*
builder.Services.AddDbContext<GoodBossContext>(options =>
{
    if (isDevelopment)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
        var connectionString = configuration.GetConnectionString("GoodBossConnection");
        options.UseSqlServer(connectionString);
    }
    else
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString("GoodBossConnection");
        options.UseSqlServer(connectionString);
    }
});
*/
#endregion

#region Sitedata 数据库

builder.Services.AddDbContext<sitedataContext>(options =>
{
    if (isDevelopment)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
        var connectionString = configuration.GetConnectionString("SitedataConnection");
        options.UseSqlServer(connectionString);
    }
    else
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var connectionString = configuration.GetConnectionString("SitedataConnection");
        options.UseSqlServer(connectionString);
    }
});

#endregion

var app = builder.Build();
//var ipv4 = "localhost";
//app.Use(async (context, next) =>
//{
//    //var ip = context.Request.HttpContext.Connection.RemoteIpAddress;
//    var host = context.Request.HttpContext.Request.Host.Host;

//    ipv4 = host.ToString();

//#pragma warning disable CS8604 // 引用类型参数可能为 null。
//    var configReader = new ConnectSettings(app.Services.GetService<IConfiguration>(), ipv4);
//#pragma warning restore CS8604 // 引用类型参数可能为 null。
//    // 继续执行后续中间件
//    await next();
//});

app.UseTenantDatabaseSelector();
// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.DocumentTitle = "My API";
    c.DocExpansion(DocExpansion.None);
});

app.UseCors("MyCorsPolicy");

app.UseAuthentication();// 启用认证

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<JwtTokenValidationMiddleware>();
app.Run();
