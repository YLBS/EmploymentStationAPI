using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Iservice
{
    public interface IOutDicService
    {
        Task<List<OutDicModels>> GetDicDegree();
        Task<List<OutBigDicJobDto>> GetDicJobDto();
        /// <summary>
        /// 获取城市
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        Task<List<SmalJobDto>> GetDicCity(bool option);
        /// <summary>
        /// 获取所属行业
        /// </summary>
        /// <returns></returns>
        Task<List<OutDicModels>> GetDicJobFunctionBig();

        /// <summary>
        /// 获取地区详细到镇
        /// </summary>
        /// <returns></returns>
        Task<List<OutDicTown>> GetDicTown();
        /// <summary>
        /// 获取薪水
        /// </summary>
        /// <returns></returns>
        Task<List<OutDicModels>> GetDicSalaryNew();

    }
}
