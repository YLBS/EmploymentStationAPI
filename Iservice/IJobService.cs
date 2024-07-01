using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iservice
{
    public interface IJobService
    {
        /// <summary>
        /// 查询职位列表
        /// </summary>
        /// <param name="memId"></param>
        /// <returns></returns>
        Task<(List<OutPositionDto>, int Count)> GetMemPositionList(int memId);

        /// <summary>
        /// 查询职位信息
        /// </summary>
        /// <param name="posId"></param>
        /// <returns></returns>
        Task<OutPositionDto> GetMemPositionInfo(int posId);
        /// <summary>
        /// 修改职位
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ResultModel> UpMemPosition(UpPositonDto dto);
        /// <summary>
        /// 新增职位
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ResultModel> AddMemPosition(InputPositionDto dto);
    }
}
