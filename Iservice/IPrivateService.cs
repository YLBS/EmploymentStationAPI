using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Goodjob;

namespace Iservice
{
    public interface IPrivateService
    {
        /// <summary>
        /// 添加驿站归属
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="name"></param>
        /// <param name="belongType"></param>
        /// <param name="fromId"></param>
        /// <returns></returns>
        Task<string> AddEsBelongType(string dbName,string name,int belongType,int fromId);

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        Task<(List<ResumeRegisterFrom> list1, List<JyRelevanceDb> list2)> GetData(int belongType);

        Task<object> GetResume(int myUserId);

        Task<bool> DelResume(int myUserId, int belongType); 

        /// <summary>
        /// 删除就业驿站的企业信息
        /// </summary>
        /// <returns></returns>
        Task<int> DelForJy(int memId, string title, int id);
        Task<int> RecoverMemInfo(int memId, string title, int id);
    }
}
