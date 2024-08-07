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

//����
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
#region ȫ���쳣������

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
    #region Swagger����֧������ͷ�������� 
    options.AddSecurityDefinition("TenantId", new OpenApiSecurityScheme
    {
        Description = "����tenantId",
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
        Description = "����token,��ʽΪ Bearer jwtToken",
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


#region JWT��Ȩ��Ȩ

builder.Services.Configure<JWTTokenOptions>(builder.Configuration.GetSection("JWTTokenOptions"));

JWTTokenOptions tokenOptions = new JWTTokenOptions();//��ʼ��
builder.Configuration.Bind("JWTTokenOptions", tokenOptions);//ʵ�ֵ���

//��Ȩ
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            //JWT��һЩĬ�ϵ����ԣ����Ǹ���Ȩʱ�Ϳ���ɸѡ��
            ValidateIssuer = true,//�Ƿ���֤Issuer
            ValidateAudience = true,//�Ƿ���֤Audience
            ValidateLifetime = false,//�Ƿ�����ʧЧʱ��
            ValidateIssuerSigningKey = true,//�Ƿ���֤SecurityKey
            ValidAudience = tokenOptions.Audience,
            ValidIssuer = tokenOptions.Isuser,//Issuer,�������ǰ��ǩ��jwt������һ��
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecurityKey))
        };
    });
//��Ȩ
builder.Services.AddAuthorization(options =>
{
    //Ҫ���и���ɫ�ֶ� --- ָ��Admin //[Authorize(Roles = "Admin")] //[Authorize(Policy = "AdminPolicy")]
    options.AddPolicy("AdminPolicy", policyBuilder => policyBuilder.RequireRole("Admin"));

    //Ҫ���û���Ϣ���������Role�ֶ�,������Ϣ������Admian  //[Authorize(Policy = "AssertionAdminPolicy")]
    options.AddPolicy("AssertionAdminPolicy", policyBuilder =>
            policyBuilder.RequireAssertion(context =>
                context.User.HasClaim(c => c.Type == ClaimTypes.Role)
                && context.User.Claims.First(c => c.Type.Equals(ClaimTypes.Role)).Value == "Admin")//Claim��Role��User
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
//builder.Services.AddAutoMapper(typeof(MappingProfile)); // ���AutoMapper����

builder.Services.AddHttpContextAccessor();

// ��ȡ��ǰ������IP��ַ
//var hostName = Dns.GetHostName();
//var ip = Dns.GetHostEntry(hostName).AddressList[0];

//�ж��ǲ��ǿ���ģʽ
var env = builder.Environment;
var isDevelopment = env.IsDevelopment();

#region ѡ�����ݿ�

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

#region GoodJob ���ݿ�

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

#region Goodjob_Other ���ݿ�

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

#region GoodBoss ���ݿ�
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

#region Sitedata ���ݿ�

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

//#pragma warning disable CS8604 // �������Ͳ�������Ϊ null��
//    var configReader = new ConnectSettings(app.Services.GetService<IConfiguration>(), ipv4);
//#pragma warning restore CS8604 // �������Ͳ�������Ϊ null��
//    // ����ִ�к����м��
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

app.UseAuthentication();// ������֤

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<JwtTokenValidationMiddleware>();
app.Run();
