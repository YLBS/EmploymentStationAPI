using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmploymentStationAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    public class LiveController : ControllerBase
    {
        private readonly ILiveAndZph _liveAndZph;
        public LiveController(ILiveAndZph liveAndZph)
        {
            _liveAndZph = liveAndZph;
        }
        /// <summary>
        /// 获取直播列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetLiveList(BaseFilterModels baseFilter)
        {
            var dt = await _liveAndZph.GetOutMngLivesList(baseFilter);
            return Ok(new
            {
                Code = 200,
                Data = new
                {
                    dt.Count,
                    dt.liveDtos
                }
            });
        }

        /// <summary>
        /// 获取招聘会列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetZphList(BaseFilterModels baseFilter)
        {
            var dt = await _liveAndZph.GetOutZhpList(baseFilter);
            return Ok(new
            {
                Code = 200,
                Data = new
                {
                    dt.Count,
                    dt.liveDtos
                }
            });
        }
    }
}
