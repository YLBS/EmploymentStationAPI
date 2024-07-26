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
        /// <param name="esId"></param>
        /// <returns></returns>
        Task<(List<OutPositionDto>, int Count)> GetMemPositionList(int memId, int esId);

        /// <summary>
        /// 查询职位信息
        /// </summary>
        /// <param name="posId"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        Task<OutPositionDto> GetMemPositionInfo(int posId, int esId);
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

        Task<ResultModel> UpPositionSate(int esId, int memId, int[] posIds, int sate);
    }
}
