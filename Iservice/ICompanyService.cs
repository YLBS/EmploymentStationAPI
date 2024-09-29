using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Goodjob;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Iservice
{
    public interface ICompanyService
    {
        /// <summary>
        /// 返回企业列表
        /// </summary>
        /// <returns></returns>
        Task<(List<OutMemInfoDto>,int Count)> GetOutMemInfoAsync(BaseFilterModels baseFilter, int esId, string beginDate, string endDate);
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
        Task<ResultModel> AddRegisterUnemployment(InputRegisterUnemploymentDto dto,string tenantId,int loginId);
        /// <summary>
        /// 获取人员列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        Task<(List<OutUnemploymentDto>, int Count)> GetUnemployment(BaseFilterModels baseFilter,int esId);
        /// <summary>
        /// 返回就业驿站名称
        /// </summary>
        /// <param name="adminId"></param>
        /// <returns></returns>
        Task<List<OutJiuYeStationDto>> GetJiuYeStation(int adminId);
        /// <summary>
        /// 返回失业人员列表
        /// </summary>
        /// <returns></returns>
        Task<(List<OutUnemploymentInfoDto>, int Count)> GetOutUnemploymentInfoList(BaseFilterModels baseFilter,int esId);
        /// <summary>
        /// 获取失业人员信息
        /// </summary>
        /// <param name="myUserId"></param>
        /// <returns></returns>
        Task<List<OutUnemploymentInfoDto>> GetOutUnemploymentInfo(int myUserId);
        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="unemployment"></param>
        /// <returns></returns>
        Task<ResultModel> UpUnemploymentInfo(UpRegisterUnemploymentDto unemployment);

        /// <summary>
        /// 添加企业信息
        /// </summary>
        /// <param name="inputMemInfoJy"></param>
        /// <param name="tenantId"></param>
        /// <returns></returns>
        Task<ResultModel> AddMemInfo(InputMemInfoJyDto inputMemInfoJy, string lastLoginIp, int loginId);

        /// <summary>
        /// 模糊查询，返回企业信息
        /// </summary>
        /// <param name="memName"></param>
        /// <returns></returns>
        Task<List<OutMemInfoListByName>> OutMemInfoByName(string memName);
        /// <summary>
        /// 获取求职登记
        /// </summary>
        /// <returns></returns>
       Task<(List<ApplytRegisterForJob>, int Count)> GetApplytRegisterForJob(BaseFilterModels baseFilter, int esId);
        /// <summary>
        /// 获取招聘登记
        /// </summary>
        /// <returns></returns>
        Task<(List<RecruitmentRegister>, int Count)> GetRecruitmentRegister(BaseFilterModels baseFilter, int esId);

        /// <summary>
        /// 返回需要修改的数据
        /// </summary>
        /// <returns></returns>
        Task<UpdateMemInfoJyDto> GetData(int memId,int esId,int belongType);
        /// <summary>
        /// 修改企业信息
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> Update(UpdateMemInfoJyDto info, string  title,int id);
        /// <summary>
        /// 修改账号密码
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> Update(AccountModes info, string title, int id);

        Task<int> CopyMemInfo(int[] memIds, int belongType);
       
        
    }
}
