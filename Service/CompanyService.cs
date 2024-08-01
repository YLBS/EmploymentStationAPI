using Component.Dictionary;
using Entity.Base;
using Entity.Goodjob;
using Entity.Goodjob_Other;
using Entity.Sitedata;
using Goodjob.Common;
using Iservice;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Models;
using ServiceStack;
using System.Data;
using System.Dynamic;
using System.Net;
using System.Numerics;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using BaseMemInfo = Entity.Base.BaseMemInfo;

namespace Service
{
    public class CompanyService : ICompanyService
    {
        private readonly BaseDbContext _basedb;
        private readonly GoodjobContext _goodjobdb;
        private readonly sitedataContext _sitedatadb;
        private readonly ILogger<CompanyService> _logger;

        public CompanyService(BaseDbContext dbContext, GoodjobContext dbContext1, sitedataContext sitedata, ILogger<CompanyService> logger)
        {
            _basedb = dbContext;
            _goodjobdb = dbContext1;
            _sitedatadb = sitedata;
            _logger = logger;
        }
        public async Task<(List<OutMemInfoDto>, int Count)> GetOutMemInfoAsync(BaseFilterModels baseFilter, int esId, string beginDate, string endDate)
        {
            List<OutMemInfoDto> outMemInfos = new List<OutMemInfoDto>();
            int count = 0;
            using (var command = _goodjobdb.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "GetMemInfoByEsId";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var param1 = new SqlParameter("@ESID", System.Data.SqlDbType.Int);
                param1.Value = esId;
                command.Parameters.Add(param1);
                var param2 = new SqlParameter("@PageSize", System.Data.SqlDbType.Int);
                param2.Value = baseFilter.PageSize;
                command.Parameters.Add(param2);
                var param3 = new SqlParameter("@PageNumber", System.Data.SqlDbType.Int);
                param3.Value = baseFilter.PageIndex;
                command.Parameters.Add(param3);
                var param4 = new SqlParameter("@Filter", System.Data.SqlDbType.VarChar);
                string filter = " and 1=1 ";
                if (!string.IsNullOrEmpty(baseFilter.Name))
                {
                    filter += " and MemName like '%" + baseFilter.Name + "%' ";
                }
                if (!string.IsNullOrEmpty(beginDate))
                {
                    filter += " and RegisterDate >='" + beginDate+"' ";
                }
                if (!string.IsNullOrEmpty(endDate))
                {
                    filter += " and RegisterDate <='" + endDate + "' ";
                }
                param4.Value = filter;
                command.Parameters.Add(param4);
                
                if (baseFilter.Id == 1)
                {
                    var param5 = new SqlParameter("@posSumFilter", System.Data.SqlDbType.VarChar);
                    param5.Value = " and PosNum !=0 ";
                    command.Parameters.Add(param5);
                }
                if (baseFilter.Id == 2)
                {
                    var param5 = new SqlParameter("@posSumFilter", System.Data.SqlDbType.VarChar);
                    param5.Value = " and PosNum =0 ";
                    command.Parameters.Add(param5);
                }

                await command.Connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        OutMemInfoDto outMem= new OutMemInfoDto();
                        outMem.EsId = Convert.ToInt32(reader["ESId"]);
                        outMem.MemId = Convert.ToInt32(reader["MemID"]);
                        outMem.MemName = reader["MemName"].ToString(); 
                        outMem.AddressC = Convert.ToInt32(reader["Address_C"]);
                        outMem.AddressP = Convert.ToInt32(reader["Address_P"]);
                        outMem.Address = reader["Address"].ToString();
                        outMem.ContactPerson = reader["ContactPerson"].ToString();
                        outMem.Phone = reader["Phone"].ToString();
                        outMem.RegisterDate = Convert.ToDateTime(reader["RegisterDate"]);
                        outMem.PosNum = Convert.ToInt32(reader["PosNum"]);
                        outMemInfos.Add(outMem);
                    }

                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            count = Convert.ToInt32(reader[0]);
                        }
                    }
                }

            }

            return (outMemInfos, count);
            #region MyRegion

            //var list = await _goodjobdb.Set<MemInfoJy>().Where(o=>o.Esid == esId).Select(o =>
            //    new OutMemInfoDto
            //    {
            //        EsId=o.Esid,
            //        MemId = o.MemId,
            //        MemName = o.MemName,
            //        AddressC = o.AddressC,
            //        AddressP = o.AddressP,
            //        Address = o.Address,
            //        ContactPerson = o.ContactPerson,
            //        Phone = o.Phone,
            //        RegisterDate = o.RegisterDate,
            //    }).ToListAsync();
            //if (!string.IsNullOrEmpty(baseFilter.Name))
            //{
            //    list= list.Where(o=>o.MemName.Contains(baseFilter.Name)).ToList();
            //}
            //if (baseFilter.Id!=0)
            //{
            //    //list = list.Where(o => o.MemName.Contains(baseFilter.Name)).ToList();
            //}
            //int count = list.Count;
            //list = list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
            //foreach (var item in list)
            //{
            //    item.PosNum = _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.MemId == item.MemId)
            //        .Select(o => o.PosId).Count();
            //}

            #endregion


            //return (list, count);

        }
        public async Task<List<OutMemPositionDto>> GetList(int memId)
        {
            var list = await _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.MemId == memId).Select(o =>
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
                    int belongType = Convert.ToInt32(tenantId);

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
                    //登记便签,登记记录
                    var registerSign = new RegisterSign
                    {
                        MyUserId = myUserId, 
                        Type = dto.RegisterType,
                        Esid= dto.EsId,
                        CreateTime = DateTime.Now,
                        BelongType = belongType,
                    };

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
                    ii = 0;
                    string logPath = "path/logfile.txt";
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.StackTrace);
                    }
                    await dbContextTransaction.RollbackAsync();
                }
            }
            return ii > 6;
        }

        public async Task<(List<OutUnemploymentDto>,int Count)> GetUnemployment(BaseFilterModels baseFilter, int esId)
        {
            //int belongType = RegisterFrom.Dictionarys1[tenantId];
            var list = await (from a in _goodjobdb.Set<MyUser>()
                              join b in _goodjobdb.Set<RegisterSign>() on a.MyUserId equals b.MyUserId into tableGroup1
                              from b in tableGroup1.DefaultIfEmpty()
                              join c in _goodjobdb.Set<MyResume>() on a.MyUserId equals c.MyUserId into tableGroup2
                              from c in tableGroup2.DefaultIfEmpty()
                              where b != null && b.Esid == esId
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
                                  //BelongType = a.BelongType,
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
            //list = list.Where(o=>o.BelongType== belongType).Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
            return (list, count);
        }

        public async Task<List<OutJiuYeStationDto>> GetJiuYeStation(int adminId)
        {
            List<OutJiuYeStationDto> outJiuYe = new List<OutJiuYeStationDto>();

            using (var command = _sitedatadb.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "InquireJYStation";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var typeInfoIdParam2 = new SqlParameter("@ZphAdminID", System.Data.SqlDbType.Int);
                typeInfoIdParam2.Value = adminId;
                command.Parameters.Add(typeInfoIdParam2);
                await command.Connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        OutJiuYeStationDto outJiu=new OutJiuYeStationDto();
                        outJiu.Id = Convert.ToInt32(reader["Id"]);
                        outJiu.Title = reader["Title"].ToString();
                        outJiu.AffiliatedUnit = reader["AffiliatedUnit"].ToString();
                        outJiu.Eaddress = reader["Eaddress"].ToString();
                        outJiu.Introduce = reader["Introduce"].ToString();
                        outJiu.EaddressP = Convert.ToInt32(reader["EAddressP"]);
                        outJiu.EaddressC = Convert.ToInt32(reader["EAddressC"]);
                        outJiu.EaddressD = Convert.ToInt32(reader["EAddressD"]);
                        outJiu.EaddressT = Convert.ToInt32(reader["EAddressT"]);
                        outJiu.TopImage = reader["ImageUrl1"].ToString();
                        outJiu.ListImage = reader["ImageUrl2"].ToString();
                        outJiu.EnvironmentImage = reader["ImageUrl3"].ToString();
                        outJiu.MemCount = Convert.ToInt32(reader["MemCount"]);
                        outJiu.PosCount = Convert.ToInt32(reader["PosCount"]);
                        outJiu.PeopleCount = Convert.ToInt32(reader["PeopleCount"]);
                        outJiu.BelongType = Convert.ToInt32(reader["BelongType"]);
                        outJiuYe.Add(outJiu);

                    }
                }
                await _sitedatadb.Database.CloseConnectionAsync();
            }

            foreach (OutJiuYeStationDto jy in outJiuYe)
            {
                using (var command = _sitedatadb.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "GetMem_PosCountByDB";
                    command.CommandType = CommandType.StoredProcedure;

                    var parm1 = new SqlParameter("@Type", SqlDbType.Int);
                    parm1.Value = jy.BelongType;
                    command.Parameters.Add(parm1);
                    //await command.Connection.OpenAsync();
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (reader.Read())
                        {
                            jy.MemCount += reader.GetInt32(0);
                        }
                        if (reader.NextResult())
                        {
                            while (reader.Read())
                            {
                                jy.PosCount += reader.GetInt32(0);
                            }
                        }
                    }
                    await _sitedatadb.Database.CloseConnectionAsync();
                }
            }

            return outJiuYe;
        }

        public async Task<(List<OutUnemploymentInfoDto>, int Count)> GetOutUnemploymentInfoList(BaseFilterModels baseFilter,int esId)
        {
            int count = 0;
            List<OutUnemploymentInfoDto> getList = new List<OutUnemploymentInfoDto>();
            //int belongType = RegisterFrom.Dictionarys1[tenantId];
            using (var command = _goodjobdb.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "InquireUnemploymentInfo";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                var param1 = new SqlParameter("@MyUserID", System.Data.SqlDbType.Int);
                param1.Value = 0;
                command.Parameters.Add(param1);

                var param2 = new SqlParameter("@EsId", System.Data.SqlDbType.Int);
                param2.Value = esId;
                command.Parameters.Add(param2);
                var param3 = new SqlParameter("@Filter", System.Data.SqlDbType.VarChar);
                if (string.IsNullOrEmpty(baseFilter.Name))
                {
                    param3.Value = "";
                }
                else
                {
                    param3.Value = baseFilter.Name;
                }
                command.Parameters.Add(param3);

                var param4 = new SqlParameter("@TypeId", System.Data.SqlDbType.VarChar);
                param4.Value = baseFilter.Id;
                command.Parameters.Add(param4);

                var param5 = new SqlParameter("@PageIndex", System.Data.SqlDbType.VarChar);
                param5.Value = baseFilter.PageIndex;
                command.Parameters.Add(param5);

                var param6 = new SqlParameter("@PageSize", System.Data.SqlDbType.VarChar);
                param6.Value = baseFilter.PageSize;
                command.Parameters.Add(param6);

                // 打开连接并执行
                await command.Connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    // 处理结果集
                    while (await reader.ReadAsync())
                    {
                        OutUnemploymentInfoDto dto = new OutUnemploymentInfoDto();
                        dto.MyUserId = Convert.ToInt32(reader["MyUserId"]);
                        dto.UserName = reader["UserName"].ToString();
                        dto.Email = reader["Email"].ToString();
                        dto.PhoneNum = reader["PhoneNum"].ToString();
                        dto.Sex = Convert.ToInt32(reader["Sex"]);
                        dto.Nationality = Convert.ToInt32(reader["Nationality"]);
                        dto.Birthday = Convert.ToDateTime(reader["Birthday"]);
                        dto.CardType = Convert.ToInt32(reader["CardType"]);
                        dto.CardNum = reader["CardNum"].ToString();
                        dto.Height = Convert.ToInt32(reader["Height"]);
                        dto.Weight = Convert.ToInt32(reader["Weight"]);
                        dto.MaritalStatus = Convert.ToInt32(reader["MaritalStatus"]);
                        dto.HometownP = Convert.ToInt32(reader["Hometown_P"]);
                        dto.HometownC = Convert.ToInt32(reader["Hometown_C"]);
                        dto.LocationP = Convert.ToInt32(reader["Location_P"]);
                        dto.LocationC = Convert.ToInt32(reader["Location_C"]);
                        dto.SelfDescription = reader["SelfDescription"].ToString();
                        dto.ZipCode = reader["ZipCode"].ToString();
                        dto.ResumeTitle = reader["JobSeeking"].ToString();
                        dto.EduText = reader["EduText"].ToString();
                        dto.WorkText = reader["WorkText"].ToString();
                        dto.LastPosName = reader["LastPosName"].ToString();
                        dto.WorkedYear = Convert.ToInt32(reader["WorkedYear"]);
                        dto.JobLocationP = reader["JobLocation_P"] is DBNull ? 0 : Convert.ToInt32(reader["JobLocation_P"]);
                        dto.JobLocationC = reader["JobLocation_C"] is DBNull ? 0 : Convert.ToInt32(reader["JobLocation_C"]);
                        dto.RegisterType = Convert.ToInt32(reader["Type"]);
                        dto.DegreeId = Convert.ToInt32(reader["DegreeId"]);
                        getList.Add(dto);
                    }

                    if (await reader.NextResultAsync())
                    {
                        while (await reader.ReadAsync())
                            count = reader.GetInt32(0);
                    }
                }
            }
            //foreach (var itemDto in getList)
            //{
            //    var list1 = await _goodjobdb.Set<MyJobFunction1>().Where(m => m.MyUserId == itemDto.MyUserId)
            //        .ToListAsync();
            //    foreach (var item in list1)
            //    {
            //        if (itemDto.JobFunctionList == null)
            //            itemDto.JobFunctionList = new List<MyJobFunctionModels>();
            //        MyJobFunctionModels model = new MyJobFunctionModels();
            //        model.JobFunctionBig = item.JobFunctionBig;
            //        model.JobFunctionSmall = item.JobFunctionSmall;
            //        model.JobFunctionId = item.JobFunctionId;
            //        itemDto.JobFunctionList.Add(model);
            //    }
            //}

            //getList= getList.Skip((baseFilter.PageIndex-1)*baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
            return (getList,count);
        }

        public async Task<bool> UpUnemploymentInfo(UpRegisterUnemploymentDto unemployment)
        {
            int ii = 0;
            using (var dbContextTransaction = await _goodjobdb.Database.BeginTransactionAsync())
            {
                try
                {
                    

                    int myUserId = unemployment.MyUserId;
                    //录入来源
                    //int registerFrom = RegisterFrom.Dictionarys[tenantId];
                    //简历属性
                    //int belongType = RegisterFrom.Dictionarys1[tenantId];
                    var userInfo = await _goodjobdb.Set<MyUser>().Where(m => m.MyUserId == myUserId).SingleAsync();
                    userInfo.UserName = unemployment.UserName;
                    userInfo.PhoneNum = unemployment.PhoneNum;
                    userInfo.Email = unemployment.Email;
                    var myResumeInfo = await _goodjobdb.Set<MyResume>().Where(m => m.MyUserId == myUserId).SingleAsync();
                    myResumeInfo.PerName = unemployment.UserName;
                    myResumeInfo.Height = (short)unemployment.Height;
                    myResumeInfo.Weight = (short)unemployment.Weight;
                    myResumeInfo.Sex = (byte)unemployment.Sex;
                    myResumeInfo.MobileNum = unemployment.PhoneNum;
                    myResumeInfo.Birthday = unemployment.Birthday;
                    myResumeInfo.LocationP = unemployment.LocationP;
                    myResumeInfo.LocationC = unemployment.LocationC;
                    myResumeInfo.HometownP = unemployment.HometownP;
                    myResumeInfo.HometownC = unemployment.HometownC;
                    myResumeInfo.ZipCode = unemployment.ZipCode;
                    myResumeInfo.CardType = (byte)unemployment.CardType;
                    myResumeInfo.CardNum = unemployment.CardNum;
                    myResumeInfo.MaritalStatus = (byte)unemployment.MaritalStatus;
                    myResumeInfo.Nationality = (byte)unemployment.Nationality;
                    myResumeInfo.JobSeeking = unemployment.ResumeTitle;
                    myResumeInfo.DegreeId = (byte)unemployment.DegreeId;
                    myResumeInfo.WorkedYear = (byte)unemployment.WorkedYear;
                    myResumeInfo.SelfDescription = unemployment.SelfDescription;
                    myResumeInfo.LocationC = unemployment.LocationC;
                    var myJobLocationInfo = await _goodjobdb.Set<MyJobLocation>().Where(m => m.MyUserId == myUserId).FirstOrDefaultAsync();
                    if(myJobLocationInfo != null){
                        myJobLocationInfo.JobLocationP = unemployment.JobLocationP;
                        myJobLocationInfo.JobLocationC = unemployment.JobLocationC;
                    }
                    else
                    {
                        var myJobLocation = new MyJobLocation()
                        {
                            MyUserId = myUserId,
                            JobLocationC = unemployment.JobLocationC,
                            JobLocationP = unemployment.JobLocationP,
                        };
                        await _goodjobdb.Set<MyJobLocation>().AddAsync(myJobLocation);
                    }

                    var myJobFunctionInfo = await _goodjobdb.Set<MyJobFunction1>().Where(m => m.MyUserId == myUserId).ToListAsync();
                    if(myJobFunctionInfo.Count != 0)
                    {
                        _goodjobdb.RemoveRange(myJobFunctionInfo);
                    }
                    foreach (var item in unemployment.JobFunctionList)
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

                    try
                    {
                        var myResumeOldTextInfo = await _goodjobdb.Set<MyResumeOldText>().Where(m => m.MyUserId == myUserId).SingleAsync();
                        myResumeOldTextInfo.EduText = unemployment.EduText;
                        myResumeOldTextInfo.WorkText = unemployment.WorkText;
                    }
                    catch (Exception e)
                    {
                        var myResumeOldText = new MyResumeOldText()
                        {
                            MyUserId = myUserId,
                            EduText = unemployment.EduText,
                            WorkText = unemployment.WorkText,
                        };
                        await _goodjobdb.Set<MyResumeOldText>().AddAsync(myResumeOldText);
                    }
                    

                    //_goodjobdb.UpdateRange(userInfo, myResumeInfo, myJobLocationInfo, myJobFunctionInfo, myResumeOldTextInfo);

                    var registerSign = await _goodjobdb.Set<RegisterSign>().Where(m => m.MyUserId == myUserId).SingleAsync();
                    registerSign.Type = unemployment.RegisterType;

                    #region update Goodjob_Query.dbo.MyResume_Query

                    var parms = new SqlParameter[]
                    {
                        new SqlParameter("@PerName", unemployment.UserName),
                        new SqlParameter("@Sex", unemployment.Sex),
                        new SqlParameter("@Birthday", unemployment.Birthday),
                        new SqlParameter("@Hometown_P", unemployment.HometownP),
                        new SqlParameter("@Hometown_C", unemployment.HometownC),
                        new SqlParameter("@Location_P", unemployment.LocationP),
                        new SqlParameter("@Location_C", unemployment.LocationC),
                        new SqlParameter("@DegreeID", unemployment.DegreeId),
                        new SqlParameter("@WorkedYear", unemployment.WorkedYear),
                        new SqlParameter("@LastPosName", unemployment.LastPosName),
                        new SqlParameter("@MyUserID", unemployment.MyUserId),
                    };
                    //var parameters = new object[] { unemployment.UserName, unemployment.Sex, unemployment.Birthday, unemployment.HometownP, unemployment.HometownC, unemployment.LocationP, unemployment.LocationC, unemployment.DegreeId, unemployment.WorkedYear, unemployment.LastPosName };
                    string sql =
                        "update Goodjob_Query.dbo.MyResume_Query  set PerName=@PerName, Sex=@Sex,Birthday=@Birthday,Hometown_P=@Hometown_P,Hometown_C=@Hometown_C,Location_P=@Location_P,Location_C=@Location_C,DegreeID=@DegreeID,WorkedYear=@WorkedYear,LastPosName=@LastPosName,UpdateDate=GETDATE()  where MyUserID=@MyUserID";
                   int i= _goodjobdb.Database.ExecuteSqlRaw(sql, parms);
                   if(i == 0){
                       #region insert into Goodjob_Query.dbo.MyResume_Query
                       var parms1 = new SqlParameter[]{
                           new SqlParameter() { ParameterName = "@MyUserID", SqlDbType =  SqlDbType.Int, Size = 100, Value = myUserId },
                           new SqlParameter() {  ParameterName = "@PerName", SqlDbType =  SqlDbType.VarChar, Size = 100, Value = unemployment.UserName },
                           new SqlParameter() { ParameterName = "@Sex", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.Sex },
                           new SqlParameter() { ParameterName = "@Birthday", SqlDbType =  SqlDbType.SmallDateTime, Size = 100, Value = unemployment.Birthday },
                           new SqlParameter() { ParameterName = "@Hometown_P", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.HometownP },
                           new SqlParameter() { ParameterName = "@Hometown_C", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.HometownC  },
                           new SqlParameter() { ParameterName = "@Location_P",  SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.LocationP },
                           new SqlParameter() { ParameterName = "@Location_C", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.LocationC },
                           new SqlParameter() { ParameterName = "@DegreeID", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.DegreeId },
                           new SqlParameter() { ParameterName = "@WorkedYear", SqlDbType =  SqlDbType.Int, Size = 100, Value = unemployment.WorkedYear },

                           new SqlParameter() { ParameterName = "@LastPosName", SqlDbType =  SqlDbType.VarChar, Size = 100, Value = unemployment.LastPosName},
                           new SqlParameter() { ParameterName = "@ResumeStatus", SqlDbType =  SqlDbType.Int, Size = 100, Value = 1 },
                           new SqlParameter() { ParameterName = "@BelongType", SqlDbType =  SqlDbType.Int, Size = 100, Value = userInfo.BelongType },
                       };

                       _goodjobdb.Database.ExecuteSqlRaw("EXEC [dbo].[Insert_MyResume_Query] @MyUserID,@PerName,@Sex,@Birthday,@Hometown_P,@Hometown_C,@Location_P,@Location_C,@DegreeID,@WorkedYear,@LastPosName,@ResumeStatus,@BelongType", parms1);
                       #endregion
                    }

                    #endregion


                    ii = await _goodjobdb.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                }
                catch (Exception e)
                {
                    string logPath = "path/logfile.txt"; 
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.StackTrace);
                    }
                    await dbContextTransaction.RollbackAsync();
                }
            }
            return ii > 0;
        }

        public async Task<List<OutUnemploymentInfoDto>> GetOutUnemploymentInfo(int myUserId)
        {
            
            //int belongType = RegisterFrom.Dictionarys1[tenantId];
            List<OutUnemploymentInfoDto> getList = new List<OutUnemploymentInfoDto>();

            using (var command = _goodjobdb.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "InquireUnemploymentInfo";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var typeInfoIdParam1 = new SqlParameter("@MyUserID", System.Data.SqlDbType.Int);
                typeInfoIdParam1.Value = myUserId;
                command.Parameters.Add(typeInfoIdParam1);

                var typeInfoIdParam2 = new SqlParameter("@EsId", System.Data.SqlDbType.Int);
                typeInfoIdParam2.Value = 0;
                command.Parameters.Add(typeInfoIdParam2);

                var typeInfoIdParam3 = new SqlParameter("@Filter", System.Data.SqlDbType.VarChar);
                typeInfoIdParam3.Value = "";
                command.Parameters.Add(typeInfoIdParam3);

                var typeInfoIdParam4 = new SqlParameter("@TypeId", System.Data.SqlDbType.VarChar);
                typeInfoIdParam4.Value = 0;
                command.Parameters.Add(typeInfoIdParam4);

                // 打开连接并执行
                await command.Connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    // 处理结果集
                    while (await reader.ReadAsync())
                    {
                        OutUnemploymentInfoDto dto = new OutUnemploymentInfoDto();
                        dto.MyUserId = Convert.ToInt32(reader["MyUserId"]);
                        dto.UserName = reader["UserName"].ToString();
                        dto.Email = reader["Email"].ToString();
                        dto.PhoneNum = reader["PhoneNum"].ToString();
                        dto.Sex = Convert.ToInt32(reader["Sex"]);
                        dto.Nationality = Convert.ToInt32(reader["Nationality"]);
                        dto.Birthday = Convert.ToDateTime(reader["Birthday"]);
                        dto.CardType = Convert.ToInt32(reader["CardType"]);
                        dto.CardNum = reader["CardNum"].ToString();
                        dto.Height = Convert.ToInt32(reader["Height"]);
                        dto.Weight = Convert.ToInt32(reader["Weight"]);
                        dto.MaritalStatus = Convert.ToInt32(reader["MaritalStatus"]);
                        dto.HometownP = Convert.ToInt32(reader["Hometown_P"]);
                        dto.HometownC = Convert.ToInt32(reader["Hometown_C"]);
                        dto.LocationP = Convert.ToInt32(reader["Location_P"]);
                        dto.LocationC = Convert.ToInt32(reader["Location_C"]);
                        dto.SelfDescription = reader["SelfDescription"].ToString();
                        dto.ZipCode = reader["ZipCode"].ToString();
                        dto.ResumeTitle = reader["JobSeeking"].ToString();
                        dto.EduText = reader["EduText"].ToString();
                        dto.WorkText = reader["WorkText"].ToString();
                        dto.LastPosName = reader["LastPosName"].ToString();
                        dto.WorkedYear = Convert.ToInt32(reader["WorkedYear"]);
                        dto.JobLocationP = reader["JobLocation_P"] is DBNull ? 0 : Convert.ToInt32(reader["JobLocation_P"]);
                        dto.JobLocationC = reader["JobLocation_C"] is DBNull ? 0 : Convert.ToInt32(reader["JobLocation_C"]);
                        dto.RegisterType = Convert.ToInt32(reader["Type"]);
                        dto.DegreeId = Convert.ToInt32(reader["DegreeId"]);
                        getList.Add(dto);
                    }
                }
            }
            foreach (var itemDto in getList)
            {
                var list1 = await _goodjobdb.Set<MyJobFunction1>().Where(m => m.MyUserId == itemDto.MyUserId)
                    .ToListAsync();
                foreach (var item in list1)
                {
                    if (itemDto.JobFunctionList == null)
                        itemDto.JobFunctionList = new List<MyJobFunctionModels>();
                    MyJobFunctionModels model = new MyJobFunctionModels();
                    model.JobFunctionBig = item.JobFunctionBig;
                    model.JobFunctionSmall = item.JobFunctionSmall;
                    model.JobFunctionId = item.JobFunctionId;
                    itemDto.JobFunctionList.Add(model);
                }
            }
            return getList;
        }

        public async Task<ResultModel> AddMemInfo(InputMemInfoJyDto inputMemInfoJy, string lastLoginIp, int loginId)
        {

            ResultModel resultModel = new ResultModel();
            #region MyRegion
            var list = await _goodjobdb.Set<MemInfoJy>().Where(m => m.MemName == inputMemInfoJy.MemName && m.MemName != "").FirstOrDefaultAsync();
            var list1 = await _basedb.Set<BaseMemInfo>().Where(m => m.MemName == inputMemInfoJy.MemName && m.MemName != "").FirstOrDefaultAsync();
            if (list != null || list1!=null)
            {
                resultModel.Result = false;
                resultModel.Message = "企业名称重复";
                return resultModel;
            }
            var list2 = await _goodjobdb.Set<MemInfoJy>().Where(m => m.Email == inputMemInfoJy.Email && m.Email != "").FirstOrDefaultAsync();
            var list3 = await _basedb.Set<BaseMemInfo>().Where(m => m.Email == inputMemInfoJy.Email && m.Email != "").FirstOrDefaultAsync();
            if (list2 != null || list3 != null)
            {
                resultModel.Result = false;
                resultModel.Message = "邮箱重复";
                return resultModel;
            }

            #endregion
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
                        new SqlParameter("@TableName", "Mem_Users"),
                        parameter);

                    int memId = (int)parameter.Value;
                    //int belongType = RegisterFrom.Dictionarys1[tenantId];
                    var memUser = new MemUser()
                    {
                        UserName = inputMemInfoJy.UserName,
                        PassWord = Goodjob.Encryption.Encryption.EncryptDES(inputMemInfoJy.PassWord.Trim()),
                        MemId = memId,
                        LastLoginIp = lastLoginIp,
                        EndValidDate= DateTime.Now.AddDays(15),
                        RegisterBy= loginId,
                    };
                    var memInfoJy = new MemInfoJy()
                    {
                        MemId = memId,
                        MemName = inputMemInfoJy.MemName,
                        LicenceNumber = "",
                        Calling = inputMemInfoJy.Calling,
                        Properity = inputMemInfoJy.Properity,
                        RegisterFund = 1,
                        EmployeeNumber = 1,
                        ContactPerson = inputMemInfoJy.ContactPerson,
                        ContactDepartment = inputMemInfoJy.ContactDepartment,
                        ContactTelZ = inputMemInfoJy.ContactTelZ,
                        ContactTel = inputMemInfoJy.ContactTel,
                        ContactTelE = inputMemInfoJy.ContactTelE,
                        TelShowFlag = inputMemInfoJy.TelShowFlag,
                        Phone = inputMemInfoJy.Phone,
                        PhoneFlag = inputMemInfoJy.PhoneFlag,
                        ZipCode = "000000",
                        AddressP = inputMemInfoJy.AddressP,
                        AddressC = inputMemInfoJy.AddressC,
                        AddressD = inputMemInfoJy.AddressD,
                        AddressT = inputMemInfoJy.AddressT,
                        Esid = inputMemInfoJy.Esid,
                       // BelongType = belongType,
                    };
                    await _goodjobdb.AddAsync(memUser);
                    await _goodjobdb.AddAsync(memInfoJy);
                    ii = await _goodjobdb.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                }
                catch (Exception e)
                {
                    string logPath = "path/logfile.txt"; 
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.StackTrace);
                    }
                    await dbContextTransaction.RollbackAsync();
                }
                
            }

            if (ii > 1)
            {
                resultModel.Result = true;
                resultModel.Message = "添加成功";
                return resultModel;
            }

            resultModel.Message = "注册失败";
            resultModel.Result = false;
            return resultModel;

        }

        public async Task<List<OutMemInfoListByName>> OutMemInfoByName(string memName)
        {
            var list = await _basedb.Set<BaseMemInfo>().Where(m => m.MemName.Contains(memName)).Select(o=>new OutMemInfoListByName
            {
                MemId=o.MemId,
                MemName=o.MemName,
                FoundDate=o.FoundDate,
                AddressP=o.AddressP,
                AddressC= o.AddressC,
                Address=o.Address,
                RegisterDate= o.RegisterDate,
                Phone= o.Phone,
            }).ToListAsync();
            var result = await _goodjobdb.Set<MemInfoJy>().Where(m => m.MemName.Contains(memName)).Select(o =>
                new OutMemInfoListByName
                {
                    MemId = o.MemId,
                    MemName = o.MemName,
                    FoundDate = o.FoundDate,
                    AddressP = o.AddressP,
                    AddressC = o.AddressC,
                    Address = o.Address,
                    RegisterDate = o.RegisterDate,
                    Phone = o.Phone,
                }).ToListAsync();
            list.AddRange(result);
            //list.Add(result);
            return list;
        }

        public async Task<(List<ApplytRegisterForJob>, int Count)> GetApplytRegisterForJob(BaseFilterModels baseFilter, int esId)
        {
            int count;
            var list = await _goodjobdb.Set<ApplytRegisterForJob>().Where(m => m.Esid == esId).ToListAsync();
            if (string.IsNullOrEmpty(baseFilter.Name))
            {
                count = list.Count;
                return (list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList(), count);
            }
            list = list.Where(o => o.ContactPerson.Contains(baseFilter.Name)).ToList();
            count = list.Count;

            return (list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList(), count);
        }

        public async Task<(List<RecruitmentRegister>,int Count)> GetRecruitmentRegister(BaseFilterModels baseFilter, int esId)
        {
            int count;
            var list = await _goodjobdb.Set<RecruitmentRegister>().Where(m => m.Esid == esId).ToListAsync();
            if (string.IsNullOrEmpty(baseFilter.Name))
            {
                count = list.Count;
                return (list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList(), count);
            }
            list = list.Where(o => o.MemName.Contains(baseFilter.Name)).ToList();
            count = list.Count;

            return (list.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList(), count);
        }
    }
}
