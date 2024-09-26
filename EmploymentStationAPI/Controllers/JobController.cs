using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 职位控制器，提供跟职位相关的API
    /// </summary>
    [Authorize]
    [Route("api/[controller]/[action]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }
        /// <summary>
        /// 新增职位
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPosition([FromBody] InputPositionDto dto)
        {
            var dt = await _jobService.AddMemPosition(dto);
            if (dt.Result)
            {
                return Ok(new { Code = 200, Data = dt.Message });
            }
            return Ok(new { Code = 400, Data = dt.Message });
        }
        /// <summary>
        /// 获取职位信息
        /// </summary>
        /// <param name="posId">职位Id</param>
        /// <param name="esId">驿站ID</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPositionInfo(int posId, int esId)
        {
            var list = await _jobService.GetMemPositionInfo(posId, esId);
            return Ok(new { Code = 200, Data = list });
        }
        /// <summary>
        /// 修改职位信息
        /// </summary>
        /// <param name="upPisition"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpPosition([FromBody] UpPositonDto upPisition)
        {
            var dt = await _jobService.UpMemPosition(upPisition);
            if (dt.Result)
            {
                return Ok(new { Code = 200, Data = dt.Message });
            }
            return Ok(new { Code = 400, Data = dt.Message });
        }
        /// <summary>
        /// 获取职位列表新
        /// </summary>
        /// <param name="memId"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPositions(int memId, int esId)
        {
            var list = await _jobService.GetMemPositionList(memId, esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });
        }
        /// <summary>
        /// 修改职位状态
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpPosState([FromBody]UpPosStateModel upPosStateModel)
        {
            var result = await _jobService.UpPositionSate(upPosStateModel);
            return Ok(new
            {
                Code = 200, Data = result
            });
        }
    }
}
