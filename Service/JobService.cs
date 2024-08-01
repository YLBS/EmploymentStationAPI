using Entity.Base;
using Entity.Goodjob;
using Goodjob.Common;
using Iservice;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Data;
using Component.Dictionary;
using Entity.Goodjob_Other;
using BaseMemPosition = Entity.Base.BaseMemPosition;

namespace Service
{
    public class JobService : IJobService
    {

        private readonly GoodjobContext _goodjobdb;
        private readonly BaseDbContext _basedb;
        private readonly Goodjob_OtherContext _goodjobOtherContext;
        public JobService(GoodjobContext dbContext1, BaseDbContext basedb, Goodjob_OtherContext goodjobOtherContext)
        {
            _goodjobdb = dbContext1;
            _basedb = basedb;
            _goodjobOtherContext = goodjobOtherContext;
        }
        public async Task<ResultModel> AddMemPosition(InputPositionDto dto)
        {
            string welfa = "";
            if (dto.Welfa.Length != 0)
            {
                welfa = string.Join("|", dto.Welfa);
                welfa = "|" + welfa + "|";
            }
            if (dto.EsId == 0)
            {
                var resultModel = new ResultModel();
                var result = await _basedb.Set<BaseMemPosition>()
                    .Where(m => m.PosName == dto.PosName && m.MemId == dto.MemId && m.PosState == 2).FirstOrDefaultAsync();
                if (result != null)
                {
                    resultModel.Result = false;
                    resultModel.Message = "职位名称重复";
                    return resultModel;
                }

                int ii = 0;
                using (var dbTransaction = await _basedb.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var parameter = new SqlParameter
                        {
                            ParameterName = "@MaxID",
                            Direction = ParameterDirection.Output,
                            SqlDbType = SqlDbType.Int
                        };

                        _basedb.Database.ExecuteSqlRaw("EXEC Sys_GetMaxID @TableName, @MaxID OUTPUT",
                            new SqlParameter("@TableName", "Mem_Position"),
                            parameter);
                        int posId = (int)parameter.Value;
                        //添加工作类别
                        foreach (var item in dto.JobFunctionList)
                        {
                            //查旧表
                            var id = _goodjobOtherContext.Set<DicJobFunction>().Where(d => d.Id == item.JobFunctionId).Select(d => d.BigId).FirstOrDefault();
                            var memPos = new BaseMemPosJobFunction
                            {
                                PosId = posId,
                                JobFunctionBig = id,
                                JobFunctionSmall = item.JobFunctionId,
                            };
                            await _basedb.Set<BaseMemPosJobFunction>().AddAsync(memPos);
                        }
                        string cityName = "";
                        foreach (var item in dto.JobLocation)
                        {
                            var jobLocation = new BaseMemPosJobLocation
                            {
                                PosId = posId,
                                JobLocationP = 1,
                                JobLocationC = item.JobLocationD, //用存市的存区名
                            };
                            cityName += NameProvider.GetCityName(item.JobLocationC) + ",";
                            await _basedb.Set<BaseMemPosJobLocation>().AddAsync(jobLocation);
                        }
                        cityName = cityName.TrimEnd(',');
                        string salaryRange = "面谈";
                        if (dto.SalaryMin != 20 && dto.SalaryMax != 20)
                        {
                            string salaryMin = DicSalaryNew1.Dictionarys[dto.SalaryMin];
                            //string salaryMax = DicSalaryNew1.Dictionarys[dto.SalaryMax];
                            salaryRange = string.Format("{0}k以上", salaryMin);
                        }

                        BaseMemPosition list = new BaseMemPosition
                        {
                            Hires = false,
                            MemId = dto.MemId,
                            MemName = dto.MemName,
                            PosId = posId,
                            PosState = 2, // 发布中
                            PosName = dto.PosName,
                            Calling = 0,
                            CandidatesNum = dto.CandidatesNum,
                            //SalaryMin = dto.SalaryMin, //无
                            //SalaryMax = dto.SalaryMax,//无
                            SalaryRange = salaryRange,
                            Salary = (byte)(dto.SalaryMin),
                            Posdecription = dto.Posdecription,
                            ReqSex = (byte)dto.ReqSex,
                            ReqDegreeId = dto.ReqDegreeId,
                            ReqWorkyear = (byte)dto.ReqWorkyear,
                            ContactPerson = dto.ContactPerson,
                            ExamAddress = dto.ExamAddress,
                            ContactTelZ = dto.ContactTelZ,
                            ContactTel = dto.ContactTel,
                            ContactTelE = dto.ContactTelE,
                            TelShowFlag = dto.TelShowFlag,
                            Email = dto.Email,
                            EmailCodeFlag = (byte)dto.EmailCodeFlag,
                            MobileNum = dto.MobileNum,
                            //SalaryMonth = dto.SalaryMonth,//无
                            JobLocation = cityName,
                            EndValidDate = DateTime.Now.AddMonths(1),
                            Welfa= welfa
                        };
                        await _basedb.AddAsync(list);
                        ii = await _basedb.SaveChangesAsync();
                        //提交事务
                        await dbTransaction.CommitAsync();

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
                        //回滚
                        await dbTransaction.RollbackAsync();
                    }
                }
                if (ii > 0)
                {
                    resultModel.Result = true;
                    resultModel.Message = "新增成功";
                    return resultModel;
                }
                resultModel.Result = false;
                resultModel.Message = "新增失败";
                return resultModel;
            }
            else
            {
                int ii = 0;
                var resultModel = new ResultModel();
                var result = await _goodjobdb.Set<MemPosition>()
                    .Where(m => m.PosName == dto.PosName && m.MemId == dto.MemId && m.PosState == 2).FirstOrDefaultAsync();
                if (result != null)
                {
                    resultModel.Result = false;
                    resultModel.Message = "职位名称重复";
                    return resultModel;
                }
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
                            new SqlParameter("@TableName", "Mem_Position"),
                            parameter);

                        int posId = (int)parameter.Value;
                        foreach (var item in dto.JobFunctionList)
                        {
                            var memPos = new MemPosJobFunction1
                            {
                                PosId = posId,
                                JobFunctionId = item.JobFunctionId,
                                JobFunctionBig = item.JobFunctionBig,
                                JobFunctionSmall = item.JobFunctionSmall,
                            };
                            await _goodjobdb.Set<MemPosJobFunction1>().AddAsync(memPos);
                        }

                        string cityName = "";
                        foreach (var item in dto.JobLocation)
                        {
                            var jobLocation = new MemPosJobLocation
                            {
                                PosId = posId,
                                JobLocationP = item.JobLocationD,
                                JobLocationC = item.JobLocationT,
                            };
                            cityName += NameProvider.GetCityName(item.JobLocationD) + NameProvider.GetTownName(item.JobLocationD, item.JobLocationT) + ",";
                            await _goodjobdb.Set<MemPosJobLocation>().AddAsync(jobLocation);
                        }
                        cityName = cityName.TrimEnd(',');
                        string salaryRange = "面谈";
                        if (dto.SalaryMin != 20 && dto.SalaryMax != 20)
                        {
                            string salaryMin = DicSalaryNew1.Dictionarys[dto.SalaryMin];
                            string salaryMax = DicSalaryNew1.Dictionarys[dto.SalaryMax];
                            salaryRange = string.Format("{0}-{1}k", salaryMin, salaryMax);
                        }

                        MemPosition list = new MemPosition
                        {
                            Hires = false,
                            MemId = dto.MemId,
                            MemName = dto.MemName,
                            PosId = posId,
                            PosState = 2, // 发布中
                            PosName = dto.PosName,
                            Calling = 0,
                            CandidatesNum = dto.CandidatesNum,
                            SalaryMin = dto.SalaryMin,
                            SalaryMax = dto.SalaryMax,
                            SalaryRange = salaryRange,
                            Salary = (byte)(salaryRange == "面谈" ? 20 : 0),
                            Posdecription = dto.Posdecription,
                            ReqSex = (byte)dto.ReqSex,
                            ReqDegreeId = dto.ReqDegreeId,
                            ReqWorkyear = (byte)dto.ReqWorkyear,
                            ContactPerson = dto.ContactPerson,
                            ExamAddress = dto.ExamAddress,
                            ContactTelZ = dto.ContactTelZ,
                            ContactTel = dto.ContactTel,
                            ContactTelE = dto.ContactTelE,
                            TelShowFlag = dto.TelShowFlag,
                            Email = dto.Email,
                            EmailCodeFlag = (byte)dto.EmailCodeFlag,
                            MobileNum = dto.MobileNum,
                            SalaryMonth = dto.SalaryMonth,
                            JobLocation = cityName,
                            EndValidDate = DateTime.Now.AddMonths(1),
                            Welfa= welfa
                        };
                        await _goodjobdb.AddAsync(list);

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
                if (ii > 0)
                {
                    resultModel.Result = true;
                    resultModel.Message = "新增成功";
                    return resultModel;
                }

                resultModel.Result = false;
                resultModel.Message = "新增失败";
                return resultModel;
            }

            
        }

        public async Task<ResultModel> UpMemPosition(UpPositonDto dto)
        {
            string welfa = "";
            if (dto.Welfa.Length != 0)
            {
                welfa = string.Join("|", dto.Welfa);
                welfa = "|" + welfa + "|";
            }
            var resultModel = new ResultModel();
            if (dto.EsId == 0)
            {
                var list = await _basedb.Set<BaseMemPosition>().Where(m => m.PosId == dto.PosId && m.MemId == dto.MemId).FirstOrDefaultAsync();
                if (list == null)
                {
                    resultModel.Result = false;
                    resultModel.Message = "没有此职位";
                    return resultModel;
                }

                int ii;
                using (var dbContextTransaction = await _basedb.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var jobLocations = _basedb.Set<BaseMemPosJobLocation>().Where(m => m.PosId == dto.PosId);
                        if (jobLocations != null)
                        {
                            _basedb.RemoveRange(jobLocations);
                        }
                        var jobFunctions = _basedb.Set<BaseMemPosJobFunction>().Where(m => m.PosId == dto.PosId);
                        if (jobFunctions != null)
                        {
                            _basedb.RemoveRange(jobFunctions);
                        }

                        string cityName = "";
                        foreach (var item in dto.JobLocation)
                        {
                            var jobLocation = new BaseMemPosJobLocation
                            {
                                PosId = dto.PosId,
                                JobLocationP = 1,
                                JobLocationC = item.JobLocationD,
                            };
                            cityName += NameProvider.GetCityName(item.JobLocationC) + ",";
                            await _basedb.Set<BaseMemPosJobLocation>().AddAsync(jobLocation);
                        }

                        foreach (var item in dto.JobFunctionList)
                        {
                            var id= _goodjobOtherContext.Set<DicJobFunction>().Where(d=>d.Id== item.JobFunctionId).Select(d=>d.BigId).FirstOrDefault();
                            var memPos = new BaseMemPosJobFunction
                            {
                                PosId = dto.PosId,
                                JobFunctionBig = id,
                                JobFunctionSmall = item.JobFunctionId,
                            };
                            await _basedb.Set<BaseMemPosJobFunction>().AddAsync(memPos);
                        }
                        string salaryRange = "面谈";
                        if (dto.SalaryMin != 20 && dto.SalaryMax != 20)
                        {
                            string salaryMin = DicSalaryNew1.Dictionarys[dto.SalaryMin];
                            string salaryMax = DicSalaryNew1.Dictionarys[dto.SalaryMax];
                            salaryRange = string.Format("{0}-{1}k", salaryMin, salaryMax);
                        }
                        list.Salary = (byte)dto.SalaryMin;
                        list.PosName = dto.PosName;
                        list.Calling = 0;
                        list.CandidatesNum = dto.CandidatesNum;
                        //list.SalaryMin = dto.SalaryMin;
                        //list.SalaryMax = dto.SalaryMax;
                        list.SalaryRange = salaryRange;
                        list.Posdecription = dto.Posdecription;
                        list.ReqSex = 0;
                        list.ReqDegreeId = dto.ReqDegreeId;
                        list.ReqWorkyear = (byte)dto.ReqWorkyear;
                        list.ContactPerson = dto.Posdecription;
                        list.ContactTelZ = dto.ContactTelZ;
                        list.ContactTel = dto.ContactTel;
                        list.ContactTelE = dto.ContactTelE;
                        list.TelShowFlag = dto.TelShowFlag;
                        list.Email = dto.Email;
                        list.EmailCodeFlag = (byte)dto.EmailCodeFlag;
                        list.MobileNum = dto.MobileNum;
                        //list.SalaryMonth = dto.SalaryMonth;
                        list.JobLocation = cityName;
                        list.Welfa = welfa;
                        ii = await _basedb.SaveChangesAsync();

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
                        ii = 0;
                    }
                }
                if (ii > 0)
                {
                    resultModel.Result = true;
                    resultModel.Message = "修改成功";
                    return resultModel;
                }

                resultModel.Result = false;
                resultModel.Message = "修改失败";
                return resultModel;
            }
            else
            {
                var list = await _goodjobdb.Set<MemPosition>().Where(m => m.PosId == dto.PosId && m.MemId == dto.MemId).FirstOrDefaultAsync();
                if (list == null)
                {
                    resultModel.Result = false;
                    resultModel.Message = "没有此职位";
                    return resultModel;
                }
                //var result = await _goodjobdb.Set<Entity.Goodjob.MemPosition>()
                //    .Where(m => m.PosName == dto.PosName && m.MemId == dto.MemId && m.PosState != 3).FirstOrDefaultAsync();
                //if (result != null)
                //{
                //    resultModel.Result = false;
                //    resultModel.Message = "职位名称重复";
                //    return resultModel;
                //}
                int ii = 0;
                using (var dbContextTransaction = await _goodjobdb.Database.BeginTransactionAsync())
                {
                    try
                    {
                        var posJobFunction = _goodjobdb.Set<MemPosJobFunction1>().Where(m => m.PosId == dto.PosId);
                        if (posJobFunction != null)
                        {
                            _goodjobdb.RemoveRange(posJobFunction);
                        }
                        var posJobLocation = _goodjobdb.Set<MemPosJobLocation>().Where(m => m.PosId == dto.PosId);
                        if (posJobLocation != null)
                        {
                            _goodjobdb.RemoveRange(posJobLocation);
                        }
                        foreach (var item in dto.JobFunctionList)
                        {
                            var memPos = new MemPosJobFunction1
                            {
                                PosId = dto.PosId,
                                JobFunctionId = item.JobFunctionId,
                                JobFunctionBig = item.JobFunctionBig,
                                JobFunctionSmall = item.JobFunctionSmall,
                            };
                            await _goodjobdb.Set<MemPosJobFunction1>().AddAsync(memPos);
                        }

                        string cityName = "";
                        foreach (var item in dto.JobLocation)
                        {
                            var jobLocation = new MemPosJobLocation
                            {
                                PosId = dto.PosId,
                                JobLocationP = item.JobLocationD,
                                JobLocationC = item.JobLocationT,
                            };
                            cityName += NameProvider.GetCityName(item.JobLocationC) + ",";
                            await _goodjobdb.Set<MemPosJobLocation>().AddAsync(jobLocation);
                        }
                        string salaryRange = "面谈";
                        if (dto.SalaryMin != 20 && dto.SalaryMax != 20)
                        {
                            string salaryMin = DicSalaryNew1.Dictionarys[dto.SalaryMin];
                            string salaryMax = DicSalaryNew1.Dictionarys[dto.SalaryMax];
                            salaryRange = string.Format("{0}-{1}k", salaryMin, salaryMax);
                        }
                        cityName = cityName.TrimEnd(',');
                        list.PosState = 2;
                        list.PosName = dto.PosName;
                        list.Calling = 0;
                        list.CandidatesNum = dto.CandidatesNum;
                        list.SalaryMin = dto.SalaryMin;
                        list.SalaryMax = dto.SalaryMax;
                        list.SalaryRange = salaryRange;
                        list.Posdecription = dto.Posdecription;
                        list.ReqSex = 0;
                        list.ReqDegreeId = dto.ReqDegreeId;
                        list.ReqWorkyear = (byte)dto.ReqWorkyear;
                        list.ContactPerson = dto.Posdecription;
                        list.ContactTelZ = dto.ContactTelZ;
                        list.ContactTel = dto.ContactTel;
                        list.ContactTelE = dto.ContactTelE;
                        list.TelShowFlag = dto.TelShowFlag;
                        list.Email = dto.Email;
                        list.EmailCodeFlag = (byte)dto.EmailCodeFlag;
                        list.MobileNum = dto.MobileNum;
                        list.SalaryMonth = dto.SalaryMonth;
                        list.JobLocation = cityName;
                        list.Welfa = welfa;
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
                        ii = 0;
                    }
                }
                if (ii > 0)
                {
                    resultModel.Result = true;
                    resultModel.Message = "修改成功";
                    return resultModel;
                }

                resultModel.Result = false;
                resultModel.Message = "修改失败";
                return resultModel;
            }
            
        }

        public async Task<(List<OutPositionDto>, int Count)> GetMemPositionList(int memId,int esId)
        {
            if (esId == 0)
            {
                byte[] state = {0,2};
                var data = await _basedb.Set<BaseMemPosition>()
                    .Where(m => state.Contains(m.PosState) && m.MemId == memId).Select(o => new OutPositionDto
                    {
                        EsId = esId,
                        Salary = o.Salary,
                        MemId = o.MemId,
                        MemName = o.MemName,
                        PosId = o.PosId,
                        PosName = o.PosName,
                        PosType = o.PosType,
                        CandidatesNum = o.CandidatesNum,
                        Posdecription = o.Posdecription,
                        ReqSex = o.ReqSex,
                        ReqDegreeId = o.ReqDegreeId,
                        ReqWorkyear = o.ReqWorkyear,
                        ExamAddress = o.ExamAddress,
                        ContactPerson = o.ContactPerson,
                        ContactTelZ = o.ContactTelZ,
                        ContactTel = o.ContactTel,
                        ContactTelE = o.ContactTelE,
                        TelShowFlag = o.TelShowFlag,
                        Email = o.Email,
                        EmailCodeFlag = o.EmailCodeFlag,
                        MobileNum = o.MobileNum,
                        PosState = o.PosState,
                        WelfaStr=o.Welfa,
                    }).ToListAsync();
                int count = data.Count;
                foreach (var item in data)
                {
                    //处理职位类别
                    var jobTypeIds = await _basedb.Set<BaseMemPosJobFunction>().Where(m => m.PosId == item.PosId).Select(o => o.JobFunctionSmall).ToListAsync();
                    var list2 = await _goodjobOtherContext.Set<DicJobFunction1>().Where(m => jobTypeIds.Contains(m.Id)).ToListAsync();
                    foreach (var item1 in list2)
                    {
                        MyJobFunctionModels myJob = new MyJobFunctionModels();
                        myJob.JobFunctionBig = item1.BigId;
                        myJob.JobFunctionSmall = item1.SmalId;
                        myJob.JobFunctionId = item1.Id;
                        if (item.JobFunctionList == null)
                            item.JobFunctionList = new List<MyJobFunctionModels>();
                        item.JobFunctionList.Add(myJob);
                    }


                    var list1 = await _basedb.Set<BaseMemPosJobLocation>().Where(m => m.PosId == item.PosId).Select(o =>
                        new JobLocationDto
                        {
                            JobLocationP = 1,
                            JobLocationC = 724,
                            JobLocationD = o.JobLocationC,
                            JobLocationT = 0,
                        }).ToListAsync();
                    if (item.JobLocation == null)
                        item.JobLocation = new List<JobLocationDto>();
                    item.JobLocation.AddRange(list1);
                }
                return (data, count);
            }
            else
            {
                byte[] state = { 0, 2 };
                var data = await _goodjobdb.Set<MemPosition>().Where(m => state.Contains(m.PosState) && m.MemId == memId).Select(o => new OutPositionDto
                {
                    EsId = esId,
                    MemId = o.MemId,
                    MemName = o.MemName,
                    PosId = o.PosId,
                    PosName = o.PosName,
                    PosType = o.PosType,
                    CandidatesNum = o.CandidatesNum,
                    SalaryMax = o.SalaryMax,
                    SalaryMin = o.SalaryMin,
                    Posdecription = o.Posdecription,
                    ReqSex = o.ReqSex,
                    ReqDegreeId = o.ReqDegreeId,
                    ReqWorkyear = o.ReqWorkyear,
                    //JobLocationStr = o.JobLocation,
                    ExamAddress = o.ExamAddress,
                    ContactPerson = o.ContactPerson,
                    ContactTelZ = o.ContactTelZ,
                    ContactTel = o.ContactTel,
                    ContactTelE = o.ContactTelE,
                    TelShowFlag = o.TelShowFlag,
                    Email = o.Email,
                    EmailCodeFlag = o.EmailCodeFlag,
                    MobileNum = o.MobileNum,
                    SalaryMonth = o.SalaryMonth,
                    PosState = o.PosState,
                    WelfaStr = o.Welfa,
                }).ToListAsync();
                int count = data.Count;
                foreach (var item in data)
                {
                    var list = await _goodjobdb.Set<MemPosJobFunction1>().Where(m => m.PosId == item.PosId).Select(o => new MyJobFunctionModels
                    {
                        JobFunctionId = o.JobFunctionId,
                        JobFunctionBig = o.JobFunctionBig,
                        JobFunctionSmall = o.JobFunctionSmall,
                    }).ToListAsync();
                    if (item.JobFunctionList == null)
                        item.JobFunctionList = new List<MyJobFunctionModels>();
                    item.JobFunctionList.AddRange(list);

                    var list1 = await _goodjobdb.Set<MemPosJobLocation>().Where(m => m.PosId == item.PosId).Select(o =>
                        new JobLocationDto
                        {
                            JobLocationP = 1,
                            JobLocationC = 724,
                            JobLocationD = o.JobLocationP,
                            JobLocationT = o.JobLocationC,
                        }).ToListAsync();
                    if (item.JobLocation == null)
                        item.JobLocation = new List<JobLocationDto>();
                    item.JobLocation.AddRange(list1);
                }

                //data = data.Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToList();
                return (data, count);
            }

            

        }

        public async Task<OutPositionDto> GetMemPositionInfo(int posId, int esId)
        {
            if (esId == 0)
            {
                OutPositionDto outPosition = new OutPositionDto();
                //byte state = 2;
                var data = await _basedb.Set<BaseMemPosition>().Where(m => m.PosId == posId).Select(o => new OutPositionDto
                    {
                        EsId = esId,
                        Salary = o.Salary,
                        SalaryRange = o.SalaryRange,
                        MemId = o.MemId,
                        MemName = o.MemName,
                        PosId = o.PosId,
                        PosName = o.PosName,
                        PosType = o.PosType,
                        CandidatesNum = o.CandidatesNum,
                        Posdecription = o.Posdecription,
                        ReqSex = o.ReqSex,
                        ReqDegreeId = o.ReqDegreeId,
                        ReqWorkyear = o.ReqWorkyear,
                        ExamAddress = o.ExamAddress,
                        ContactPerson = o.ContactPerson,
                        ContactTelZ = o.ContactTelZ,
                        ContactTel = o.ContactTel,
                        ContactTelE = o.ContactTelE,
                        TelShowFlag = o.TelShowFlag,
                        Email = o.Email,
                        EmailCodeFlag = o.EmailCodeFlag,
                        MobileNum = o.MobileNum,
                        WelfaStr = o.Welfa,
                }).FirstOrDefaultAsync();
                if (data == null)
                {
                    return data;
                }
                //处理工作地址
                //var list = await _basedb.Set<BaseMemPosJobLocation>().Where(m => m.PosId == posId).Select(o=>o.JobLocationC).ToListAsync();
                var list = await _basedb.Set<BaseMemPosJobLocation>().Where(m => m.PosId == data.PosId).Select(o =>
                    new JobLocationDto
                    {
                        JobLocationP = 1,
                        JobLocationC = 724,
                        JobLocationD = o.JobLocationC == 724 ? 0 : o.JobLocationC,
                        JobLocationT = 0,
                    }).ToListAsync();
                if (data.JobLocation == null)
                    data.JobLocation = new List<JobLocationDto>();
                data.JobLocation.AddRange(list);

                //处理职位类别
                var jobTypeIds = await _basedb.Set<BaseMemPosJobFunction>().Where(m => m.PosId == posId).Select(o => o.JobFunctionSmall).ToListAsync();
                var list1 = await _goodjobOtherContext.Set<DicJobFunction1>().Where(m => jobTypeIds.Contains(m.Id) ).ToListAsync();
                foreach (var item in list1)
                {
                    MyJobFunctionModels myJob=new MyJobFunctionModels();
                    myJob.JobFunctionBig = item.BigId;
                    myJob.JobFunctionSmall = item.SmalId;
                    myJob.JobFunctionId = item.Id;
                    if(data.JobFunctionList == null)
                        data.JobFunctionList = new List<MyJobFunctionModels>();
                    data.JobFunctionList.Add(myJob);
                }
                return data;
            }
            else
            {
                var data = await _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.PosId == posId).Select(o => new OutPositionDto
                {
                    EsId = esId,
                    MemId = o.MemId,
                    MemName = o.MemName,
                    PosId = o.PosId,
                    PosName = o.PosName,
                    PosType = o.PosType,
                    CandidatesNum = o.CandidatesNum,
                    Salary = o.Salary,
                    SalaryMax = o.SalaryMax,
                    SalaryMin = o.SalaryMin,
                    SalaryRange = o.SalaryRange,
                    Posdecription = o.Posdecription,
                    ReqSex = o.ReqSex,
                    ReqDegreeId = o.ReqDegreeId,
                    ReqWorkyear = o.ReqWorkyear,
                    //JobLocationStr = o.JobLocation,
                    ExamAddress = o.ExamAddress,
                    ContactPerson = o.ContactPerson,
                    ContactTelZ = o.ContactTelZ,
                    ContactTel = o.ContactTel,
                    ContactTelE = o.ContactTelE,
                    TelShowFlag = o.TelShowFlag,
                    Email = o.Email,
                    EmailCodeFlag = o.EmailCodeFlag,
                    MobileNum = o.MobileNum,
                    SalaryMonth = o.SalaryMonth,
                    WelfaStr = o.Welfa,
                }).FirstOrDefaultAsync();
                if (data == null)
                {
                    return data;
                }

                var list = await _goodjobdb.Set<MemPosJobFunction1>().Where(m => m.PosId == data.PosId).Select(o => new MyJobFunctionModels
                {
                    JobFunctionId = o.JobFunctionId,
                    JobFunctionBig = o.JobFunctionBig,
                    JobFunctionSmall = o.JobFunctionSmall,
                }).ToListAsync();
                if (data.JobFunctionList == null)
                    data.JobFunctionList = new List<MyJobFunctionModels>();
                data.JobFunctionList.AddRange(list);

                var list1 = await _goodjobdb.Set<MemPosJobLocation>().Where(m => m.PosId == data.PosId).Select(o =>
                    new JobLocationDto
                    {
                        JobLocationP = 1,
                        JobLocationC = 724,
                        JobLocationD = o.JobLocationP,
                        JobLocationT = o.JobLocationC,
                    }).ToListAsync();
                if (data.JobLocation == null)
                    data.JobLocation = new List<JobLocationDto>();
                data.JobLocation.AddRange(list1);

                return data;
            }
        }

        public async Task<ResultModel> UpPositionSate(int esId,int memId, int[] posIds, int state)
        {
            int i = 0;
            ResultModel result = new ResultModel();
            if (esId == 0)
            {
                var list = await _basedb.Set<BaseMemPosition>().Where(m => posIds.Contains(m.PosId) && m.MemId== memId).ToListAsync();
                if (list.Count!=0){
                }
                foreach (var item in list)
                {
                    item.PosState = (byte)state;
                }
                i = await _basedb.SaveChangesAsync();
            }
            else
            {
                var list = await _goodjobdb.Set<MemPosition>().Where(m => posIds.Contains(m.PosId) && m.MemId == memId).ToListAsync();
                foreach (var item in list)
                {
                    item.PosState = (byte)state;
                }

                i = await _goodjobdb.SaveChangesAsync();
            }

            result.Result = true;
            result.Message = $"成功过更新{i}条数据";
            return result;
        }
    }
}
