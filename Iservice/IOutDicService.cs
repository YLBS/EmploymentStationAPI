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

    }
}
