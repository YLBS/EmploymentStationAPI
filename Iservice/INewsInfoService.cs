using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Base;
using Models;

namespace Iservice
{
    public interface INewsInfoService
    {
        public Task<ResultModel> AddBaseNewsInfo(InputBaseNewsInfoDto infoDto);

        public Task<(List<OutBaseNewsInfoDto>, int Count)> GetBaseNewsInfos(BaseFilterModel baseFilter);
        public Task<OutBaseNewsInfoDto> GetBaseNewsInfo(int id);
        
        public Task<ResultModel> UpBaseNewsInfo(OutBaseNewsInfoDto infoDto);
    }
}
