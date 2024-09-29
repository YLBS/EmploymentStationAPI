using Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Goodjob;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Dapper;
using ServiceStack;

namespace Service
{
    public class PrivateService: IPrivateService
    {
        private readonly GoodjobContext _context;
        public PrivateService(GoodjobContext context)
        {
            _context = context;
        }

        public async Task<string> AddEsBelongType(string dbName, string name, int belongType, int fromId)
        {
            string msg;
            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var s = await _context.JyRelevanceDbs.Where(j => j.BelongType == belongType).FirstOrDefaultAsync();
                    if (s != null)
                    {
                        return "belongType重复了";
                    }

                    ResumeRegisterFrom r = new ResumeRegisterFrom();
                    r.BelongType = belongType;
                    r.FromId = fromId;
                    r.Describe = name + "就业驿站";
                    JyRelevanceDb db = new JyRelevanceDb();
                    db.IsDelete = false;
                    db.DbName = dbName;
                    db.Name = name;
                    db.BelongType = belongType;
                    await _context.ResumeRegisterFroms.AddAsync(r);
                    await _context.JyRelevanceDbs.AddAsync(db);
                    int i = await _context.SaveChangesAsync();
                    if (i == 2)
                    {
                        await dbContextTransaction.CommitAsync();
                        msg = "添加成功";
                    }
                    else
                    {
                        await dbContextTransaction.RollbackAsync();
                        msg = "添加失败,请前往数据库手动添加";
                    }
                }
                catch (Exception e)
                {
                    string logPath = "path/logfile.txt";
                    Directory.CreateDirectory(Path.GetDirectoryName(logPath)); // 确保目录存在
                    using (StreamWriter sw = File.AppendText(logPath))
                    {
                        sw.WriteLine("Error occurred at: " + DateTime.Now);
                        sw.WriteLine(e.Message);
                        sw.WriteLine(e.InnerException.Message);
                    }
                    await dbContextTransaction.RollbackAsync();
                    msg = "添加失败,fromId貌似重复了";
                }
            }

            return msg;
        }

        public async Task<bool> DelResume(int myUserId, int belongType)
        {

            var param = new { myUserId, belongType };
            var result = await _context.Database.GetDbConnection().ExecuteAsync("DelResumeForJy", param, commandType: CommandType.StoredProcedure);
            return result > 2;
        }

        public async Task<(List<ResumeRegisterFrom> list1, List<JyRelevanceDb> list2)> GetData(int belongType)
        {
            var list1= await _context.ResumeRegisterFroms.Where(r=>r.BelongType!=0 && ( belongType == 0? true: r.BelongType ==belongType)).ToListAsync();
            var list2 = await _context.JyRelevanceDbs.Where(j => (belongType == 0 ? true : j.BelongType == belongType)).ToListAsync();
            return (list1, list2);
        }

        public async Task<object> GetResume(int myUserId)
        {
            var s = await _context.MyUsers.Where(m => m.MyUserId == myUserId).FirstOrDefaultAsync();
            if(s==null)
                return "简历不存在";
            var name = await _context.JyRelevanceDbs.Where(j => j.BelongType != 0 && s.BelongType == j.BelongType).Select(j=>j.Name).FirstOrDefaultAsync();
            if (string.IsNullOrEmpty(name))
            {
                return "该简历不属于驿站";
            }
            var param = new { myUserId, s.BelongType, name };
            return param;
        }
        public async Task<int> DelForJy(int memId, string title, int id)
        {
            var s = await _context.MemInfoJies.Where(m => m.MemId == memId).FirstOrDefaultAsync();
            if (s == null)
                return 0;
            if (s.IsDelete)
                return 1;
            s.IsDelete = true;
            await _context.SaveChangesAsync();
            await AddUpLog(id, title, memId, s.MemName, 3);
            return 2;

        }
        
        public async Task<int> RecoverMemInfo(int memId, string title, int id)
        {
            var s = await _context.MemInfoJies.Where(m => m.MemId == memId).FirstOrDefaultAsync();
            if (s == null)
                return 0;
            s.IsDelete = false;
            await _context.SaveChangesAsync();
            await AddUpLog(id, title, memId, s.MemName, 4);
            return 1;

        }
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <returns></returns>
        private async Task AddUpLog(int id, string name, int memId, string memName, int type)
        {
            UpEnterpriseLog u = new UpEnterpriseLog();
            u.CreateTime = DateTime.Now;
            u.ZphAdminUserId = id;
            u.Name = name;
            u.MemId = memId;
            u.MemName = memName;
            u.UpType = type;
            await _context.UpEnterpriseLogs.AddAsync(u);
            await _context.SaveChangesAsync();
        }
    }
}
