using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.LiveAndZph;

namespace Iservice
{
    /// <summary>
    /// 直播和招聘会的接口
    /// </summary>
    public interface ILiveAndZph
    {
        /// <summary>
        /// 获取直播列表
        /// </summary>
        /// <returns></returns>
        Task<(List<OutMngLiveDto> liveDtos, int Count)> GetOutMngLivesList(BaseFilterModels baseFilter);
        /// <summary>
        /// 获取招聘会列表
        /// </summary>
        /// <returns></returns>
        Task<(List<OutZhaoPinHuiDto> liveDtos, int Count)> GetOutZhpList(BaseFilterModels baseFilter);
    }
}
