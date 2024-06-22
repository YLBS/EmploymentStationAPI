using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Iservice
{
    public interface ICompanyService
    {
        /// <summary>
        /// 返回企业列表
        /// </summary>
        /// <returns></returns>
        Task<(List<OutMemInfoDto>,int Count)> GetOutMemInfoAsync(BaseFilterModels baseFilter);
        /// <summary>
        /// 获取职位信息
        /// </summary>
        /// <param name="memId"></param>
        /// <returns></returns>
        Task<List<OutMemPositionDto>> GetList(int memId);
        /// <summary>
        /// 失业登记
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="tenantId"></param>
        /// <param name="loginId"></param>
        /// <returns></returns>
        Task<bool> AddRegisterUnemployment(InputRegisterUnemploymentDto dto,string tenantId,int loginId);
        /// <summary>
        /// 获取人员列表
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="baseFilter"></param>
        /// <returns></returns>
        Task<(List<OutUnemploymentDto>, int Count)> GetUnemployment(string tenantId, BaseFilterModels baseFilter);
        /// <summary>
        /// 返回就业驿站名称
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        Task<List<OutJiuYeStationDto>> GetJiuYeStation(int adminId);

    }
}
