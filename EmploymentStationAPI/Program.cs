using EmploymentStationAPI.ExceptionFilter;
using Entity.Base;
using Entity.Goodjob;
using Iservice;
using Microsoft.EntityFrameworkCore;
using Service;
using EmploymentStationAPI.Module;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Entity.Goodjob_Other;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Entity.Sitedata;
using Swashbuckle.AspNetCore.SwaggerUI;
using Component;
using EmploymentStationAPI.JWT;
using Microsoft.Extensions.Caching.Memory;
using ServiceStack;

var builder = WebApplication.CreateBuilder(args);

//����
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy",
        b => b
            .WithOrigins("http://zj.goodjob.cn", "http://jy.goodjob.cn")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials()
    );
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


#region JWT��֤��Ȩ
//��ʼ��JwtAuthOptions
builder.Services.Configure<JwtAuthOptions>(builder.Configuration.GetSection("JwtAuth"));

builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddJwtAuthorization();
#endregion


//builder.Services.AddScoped<DbContext, BaseDbContext>();
//builder.Services.AddScoped<DbContext, GoodjobContext>();
//builder.Services.AddScoped<DbContext, Goodjob_OtherContext>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IOutDicService, OutDicService>();

builder.Services.AddTransient<IJwtService, JwtService>();
builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddTransient<IJobService, JobService>();
builder.Services.AddTransient<ILiveAndZph, LiveAndZph>();
builder.Services.AddTransient<INewsInfoService, NewsInfoService>();
builder.Services.AddTransient<IPrivateService, PrivateService>();

var mapper = AutoMapperConfig.ConfigureAutoMapper();
builder.Services.AddSingleton(mapper);
//builder.Services.AddAutoMapper(typeof(MappingProfile)); // ���AutoMapper����

builder.Services.AddHttpContextAccessor();


//�ж��ǲ��ǿ���ģʽ
var env = builder.Environment;
var isDevelopment = env.IsDevelopment();

#region ѡ�����ݿ�

builder.Services.AddDbContext<BaseDbContext>((sp, options) =>
{
    string con = builder.Configuration.GetConnectionString("BaseConnection");
    string str = sp.GetService<IHttpContextAccessor>()?.HttpContext.GetConnectionString();
    
    string connectionString = string.Format(con, str);
    options.UseSqlServer(connectionString);
});
builder.Services.AddMemoryCache();
using var serviceProvider = builder.Services.BuildServiceProvider();
var cache = serviceProvider.GetRequiredService<IMemoryCache>();
Configs.Initialize(cache);


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

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.DocumentTitle = "My API";
    c.DocExpansion(DocExpansion.None);
});

app.UseCors("MyCorsPolicy");

app.UseMiddleware<JwtMiddleware>();
app.UseAuthentication();// ������֤

app.UseAuthorization();

app.MapControllers();

app.Run();
