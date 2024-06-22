using Component.Dictionary;
using Entity.Base;
using Entity.Goodjob;
using Entity.Goodjob_Other;
using Entity.Sitedata;
using Iservice;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Models;
using System.Data;

namespace Service
{
    public class CompanyService : ICompanyService
    {
        private readonly BaseDbContext _basedb;
        private readonly GoodjobContext _goodjobdb;
        private readonly sitedataContext _sitedatadb;

        public CompanyService(BaseDbContext dbContext, GoodjobContext dbContext1, sitedataContext sitedata)
        {
            _basedb = dbContext;
            _goodjobdb = dbContext1;
            _sitedatadb = sitedata;
        }
        public async Task<(List<OutMemInfoDto>, int Count)> GetOutMemInfoAsync(BaseFilterModels baseFilter)
        {
            // 创建一个参数表达式，代表要查询的实体类型
            //ParameterExpression param = Expression.Parameter(typeof(Entity.Base.MemInfo), "x");

            // 创建一个属性访问表达式，代表要查询的实体的某个属性
            //MemberExpression property = Expression.Property(param, "YourPropertyName");

            // 创建一个常量表达式，代表需要查询的属性的值
            //ConstantExpression value = Expression.Constant("YourValue");

            // 创建一个等于表达式，表示属性与常量的比较
            //BinaryExpression equal = Expression.Equal(property, value);

            // 将所有表达式组合成一个lambda表达式
            //Expression<Func<Entity.Base.MemInfo, bool>> lambda = Expression.Lambda<Func<Entity.Base.MemInfo, bool>>(equal, param);

            var list = await _basedb.Set<Entity.Base.MemInfo>().Select(o =>
                new OutMemInfoDto
                {
                    MemId = o.MemId,
                    MemName = o.MemName,
                    AddressC = o.AddressC,
                    AddressP = o.AddressP,
                    Address = o.Address,
                    ContactPerson = o.ContactPerson,
                    Phone = o.Phone,
                    RegisterDate = o.RegisterDate,
                }).ToListAsync();
            if (!string.IsNullOrEmpty(baseFilter.Name))
            {
                list= list.Where(o=>o.MemName.Contains(baseFilter.Name)).ToList();
            }
            if (baseFilter.Id!=0)
            {
                //list = list.Where(o => o.MemName.Contains(baseFilter.Name)).ToList();
            }
            int count = list.Count;
            list = list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
            foreach (var item in list)
            {
                item.PosNum = _basedb.Set<Entity.Base.MemPosition>().Where(m => m.MemId == item.MemId)
                    .Select(o => o.PosId).Count();
            }

            return (list, count);

        }
        public async Task<List<OutMemPositionDto>> GetList(int memId)
        {
            var list = await _basedb.Set<Entity.Base.MemPosition>().Where(m => m.MemId == memId).Select(o =>
                new OutMemPositionDto
                {
                    MemId = o.MemId,
                    MemName = o.MemName,
                    PosId = o.PosId,
                    PosName = o.PosName,
                    CandidatesNum = o.CandidatesNum,
                    ReqWorkyear = o.ReqWorkyear,
                    ReqDegreeId = o.ReqDegreeId
                }).ToListAsync();
            return list;
        }

        public async Task<bool> AddRegisterUnemployment(InputRegisterUnemploymentDto dto, string tenantId, int loginId)
        {
            int ii = 0;
            using (var dbContextTransaction = await _goodjobdb.Database.BeginTransactionAsync())
            {
                try
                {
                    var parameter = new SqlParameter
                    {
                        ParameterName = "@MaxID",
                        Direction = ParameterDirection.Output,
                        SqlDbType = SqlDbType.Int
                    };

                    _goodjobdb.Database.ExecuteSqlRaw("EXEC Sys_GetMaxID @TableName, @MaxID OUTPUT",
                        new SqlParameter("@TableName", "My_Users"),
                        parameter);
                    
                    int myUserId = (int)parameter.Value;
                    //录入来源
                    int registerFrom = RegisterFrom.Dictionarys[tenantId];
                    //简历属性
                    int belongType = RegisterFrom.Dictionarys1[tenantId];

                    var user = new MyUser()
                    {
                        MyUserId = myUserId,
                        UserName = dto.UserName,
                        Password = "123456",
                        PhoneNum = dto.PhoneNum,
                        Email = dto.Email,
                        RegisterFrom = registerFrom,
                        BelongType = belongType,
                    };
                    var myResume = new MyResume()
                    {
                        MyUserId = myUserId,
                        PerName = dto.UserName,
                        Height = (short)dto.Height,
                        Weight = (short)dto.Weight,
                        Sex = (byte)dto.Sex,
                        MobileNum = dto.PhoneNum,
                        Birthday = dto.Birthday,
                        LocationP = dto.LocationP,//现所在地（省）
                        LocationC = dto.LocationC,//现所在地（市）
                        HometownP = dto.HometownP,
                        HometownC = dto.HometownC,
                        ZipCode = dto.ZipCode,
                        CardType = (byte)dto.CardType,
                        CardNum = dto.CardNum,
                        MaritalStatus = (byte)dto.MaritalStatus,//婚姻状况0=未婚，1=已婚，2=离异，3=保密 
                        Nationality = (byte)dto.Nationality,//民族

                        JobSeeking = dto.ResumeTitle,

                        DegreeId = (byte)dto.DegreeId,
                        WorkedYear = (byte)dto.WorkedYear,

                        SelfDescription = dto.SelfDescription,

                        CheckFlag = 1,//审核标志1=待审核，2=审核通过，3=审核不通过，4=更新后待复审 
                        WorkWrite = 1,
                        EduWrite = 1
                    };
                    //工作地区 [My_JobLocation]
                    var myJobLocation = new MyJobLocation()
                    {
                        MyUserId = myUserId,
                        JobLocationC = dto.JobLocationC,
                        JobLocationP = dto.JobLocationP,
                    };
                    //意向岗位 [My_JobFunction_s]
                    foreach (var item in dto.JobFunctionList)
                    {
                        var myJobFunction1 = new MyJobFunction1()
                        {
                            MyUserId = myUserId,
                            JobFunctionId = item.JobFunctionId,
                            JobFunctionBig = item.JobFunctionBig,
                            JobFunctionSmall = item.JobFunctionSmall,
                        };
                        await _goodjobdb.Set<MyJobFunction1>().AddAsync(myJobFunction1);
                    }

                    //教育背景，工作经历 My_Resume_OldText
                    var myResumeOldText = new MyResumeOldText()
                    {
                        MyUserId = myUserId,
                        EduText = dto.EduText,
                        WorkText = dto.WorkText,
                    };
                    //登记便签
                    var registerSign = new RegisterSign { MyUserId = myUserId, Type = dto.RegisterType };

                    var sysRegisterFrom = new SysRegisterFrom()
                    {
                        MyUserId = myUserId,
                        RegisterFrom = registerFrom,
                        RegisterFromDate = DateTime.Now
                    };
                    var myRegisterForCrm = new MyRegisterForCrm()
                    {
                        MyUserId = myUserId,
                        RegisterDate = DateTime.Now,
                        EplId = loginId, //登记人Id
                        ExtranetId = "",
                        VisitDescrption = registerFrom.ToString(),
                    };

                    await _goodjobdb.Set<MyResumeOldText>().AddAsync(myResumeOldText);
                    await _goodjobdb.Set<MyJobLocation>().AddAsync(myJobLocation);
                    await _goodjobdb.Set<MyUser>().AddAsync(user);
                    await _goodjobdb.Set<MyResume>().AddAsync(myResume);
                    await _goodjobdb.Set<RegisterSign>().AddAsync(registerSign);
                    await _goodjobdb.Set<SysRegisterFrom>().AddAsync(sysRegisterFrom);
                    await _goodjobdb.Set<MyRegisterForCrm>().AddAsync(myRegisterForCrm);

                    #region insert into Goodjob_Query.dbo.MyResume_Query
                    var parms = new SqlParameter[]{
                        new SqlParameter() { ParameterName = "@MyUserID", SqlDbType =  SqlDbType.Int, Size = 100, Value = myUserId }, 
                        new SqlParameter() {  ParameterName = "@PerName", SqlDbType =  SqlDbType.VarChar, Size = 100, Value = dto.UserName },
                        new SqlParameter() { ParameterName = "@Sex", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.Sex },
                        new SqlParameter() { ParameterName = "@Birthday", SqlDbType =  SqlDbType.SmallDateTime, Size = 100, Value = dto.Birthday }, 
                        new SqlParameter() { ParameterName = "@Hometown_P", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.HometownP },
                        new SqlParameter() { ParameterName = "@Hometown_C", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.HometownC  },
                        new SqlParameter() { ParameterName = "@Location_P",  SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.LocationP },
                        new SqlParameter() { ParameterName = "@Location_C", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.LocationC },
                        new SqlParameter() { ParameterName = "@DegreeID", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.DegreeId },
                        new SqlParameter() { ParameterName = "@WorkedYear", SqlDbType =  SqlDbType.Int, Size = 100, Value = dto.WorkedYear }, 
                        
                        new SqlParameter() { ParameterName = "@LastPosName", SqlDbType =  SqlDbType.VarChar, Size = 100, Value = dto.LastPosName}, 
                        new SqlParameter() { ParameterName = "@ResumeStatus", SqlDbType =  SqlDbType.Int, Size = 100, Value = 1 },
                        new SqlParameter() { ParameterName = "@BelongType", SqlDbType =  SqlDbType.Int, Size = 100, Value = belongType },
                    };

                    _goodjobdb.Database.ExecuteSqlRaw("EXEC [dbo].[Insert_MyResume_Query] @MyUserID,@PerName,@Sex,@Birthday,@Hometown_P,@Hometown_C,@Location_P,@Location_C,@DegreeID,@WorkedYear,@LastPosName,@ResumeStatus,@BelongType", parms);
                    #endregion


                  ii = await _goodjobdb.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                }
                catch (Exception e)
                {
                    await dbContextTransaction.RollbackAsync();
                }
            }
            return ii > 6;
        }

        public async Task<(List<OutUnemploymentDto>,int Count)> GetUnemployment(string tenantId, BaseFilterModels baseFilter)
        {
            int belongType = RegisterFrom.Dictionarys1[tenantId];
            var list = await (from a in _goodjobdb.Set<MyUser>()
                              join b in _goodjobdb.Set<RegisterSign>() on a.MyUserId equals b.MyUserId into tableGroup1
                              from b in tableGroup1.DefaultIfEmpty()
                              join c in _goodjobdb.Set<MyResume>() on a.MyUserId equals c.MyUserId into tableGroup2
                              from c in tableGroup2.DefaultIfEmpty()
                              where b != null
                              select new OutUnemploymentDto
                              {
                                  MyUserId = a.MyUserId,
                                  UserName = a.UserName,
                                  Sex = c.Sex,
                                  CheckFlag = c.CheckFlag,
                                  Birthday= (DateTime)c.Birthday,
                                  DegreeId = c.DegreeId,
                                  RegisterType = b.Type,
                                  LocationP = c.LocationP,
                                  LocationC = c.LocationC,
                                  WorkedYear = c.WorkedYear,
                                  BelongType = a.BelongType,
                              }).ToListAsync();
            if (!string.IsNullOrEmpty(baseFilter.Name))
            {
                list= list.Where(o=>o.UserName.Contains(baseFilter.Name)).ToList();
            }
            if (baseFilter.Id!=0)
            {
                list = list.Where(o => o.RegisterType == baseFilter.Id).ToList();
            }

            int count = list.Count;
            list = list.Where(o=>o.BelongType== belongType).Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
            return (list, count);
        }

        public async Task<List<OutJiuYeStationDto>> GetJiuYeStation(int adminId)
        {
            var list = await _sitedatadb.Set<JiuYeStation>().Where(j=>j.AdminUser == adminId || j.SecondaryUser == adminId).Select(o=>new OutJiuYeStationDto
            {
                Title = o.Title,
                AffiliatedUnit=o.AffiliatedUnit,
                Introduce = o.Introduce,
            }).ToListAsync();
            return list;
        }
    }
}
