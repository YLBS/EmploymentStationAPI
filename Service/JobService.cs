using Entity.Base;
using Entity.Goodjob;
using Entity.Sitedata;
using Goodjob.Common;
using Iservice;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Data;
using Component.Dictionary;

namespace Service
{
    public class JobService : IJobService
    {

        private readonly GoodjobContext _goodjobdb;
        public JobService(GoodjobContext dbContext1)
        {
            _goodjobdb = dbContext1;
        }
        public async Task<ResultModel> AddMemPosition(InputPositionDto dto)
        {
            int ii=0;
            var resultModel = new ResultModel();
            var result = await _goodjobdb.Set<Entity.Goodjob.MemPosition>()
                .Where(m => m.PosName == dto.PosName && m.MemId == dto.MemId && m.PosState != 3).FirstOrDefaultAsync();
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

                    double salaryMin = DicSalaryNew.Dictionarys[dto.SalaryMin];
                    double salaryMax = DicSalaryNew.Dictionarys[dto.SalaryMax];
                    string salaryRange = string.Format("{0}-{1}k", salaryMin, salaryMax);

                    Entity.Goodjob.MemPosition list = new Entity.Goodjob.MemPosition
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
                        Posdecription = dto.Posdecription,
                        ReqSex = (byte)dto.ReqSex,
                        ReqDegreeId = dto.ReqDegreeId,
                        ReqWorkyear = (byte)dto.ReqWorkyear,
                        ContactPerson = dto.ContactPerson,
                        ExamAddress= dto.ExamAddress,
                        ContactTelZ = dto.ContactTelZ,
                        ContactTel = dto.ContactTel,
                        ContactTelE = dto.ContactTelE,
                        TelShowFlag = dto.TelShowFlag,
                        Email = dto.Email,
                        EmailCodeFlag = (byte)dto.EmailCodeFlag,
                        MobileNum = dto.MobileNum,
                        SalaryMonth = dto.SalaryMonth,
                        JobLocation = cityName,
                        EndValidDate=DateTime.Now.AddMonths(1)
                    };
                    await _goodjobdb.AddAsync(list);

                    ii = await _goodjobdb.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                }
                catch(Exception e)
                {
                    string logPath = "path/logfile.txt"; // 替换为实际的文件路径
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.StackTrace);
                        // 可以添加更多的异常详情
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

        public async Task<ResultModel> UpMemPosition(UpPositonDto dto)
        {
            var resultModel = new ResultModel();
            var list = await _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.PosId == dto.PosId && m.MemId==dto.MemId).FirstOrDefaultAsync();
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
                    cityName = cityName.TrimEnd(',');
                    list.PosState = 2;
                    list.PosName = dto.PosName;
                    list.Calling = 0;
                    list.CandidatesNum = dto.CandidatesNum;
                    list.SalaryMin = dto.SalaryMin;
                    list.SalaryMax = dto.SalaryMax;
                    list.SalaryRange = string.Format("{0}-{1}", dto.SalaryMin, dto.SalaryMax);
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
                    ii = await _goodjobdb.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                }
                catch (Exception e)
                {
                    string logPath = "path/logfile.txt"; // 替换为实际的文件路径
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.StackTrace);
                        // 可以添加更多的异常详情
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

        public async Task<(List<OutPositionDto>, int Count)> GetMemPositionList(int memId)
        {
            var dt = DateTime.Now;
            var data = await _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.EndValidDate < dt && m.MemId == memId).Select(o => new OutPositionDto
            {
                MemId=o.MemId,
                MemName=o.MemName,
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
                SalaryMonth= o.SalaryMonth,
            }).ToListAsync();
            int count = data.Count;
            foreach (var item in data)
            {
                var list= await _goodjobdb.Set<MemPosJobFunction1>().Where(m => m.PosId==item.PosId).Select(o=>new MyJobFunctionModels
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

        public async Task<OutPositionDto> GetMemPositionInfo(int posId)
        {
            var data = await _goodjobdb.Set<Entity.Goodjob.MemPosition>().Where(m => m.PosId == posId).Select(o => new OutPositionDto
            {
                MemId = o.MemId,
                MemName = o.MemName,
                PosId = o.PosId,
                PosName = o.PosName,
                PosType = o.PosType,
                CandidatesNum = o.CandidatesNum,
                SalaryMax=o.SalaryMax,
                SalaryMin=o.SalaryMin,
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
}
