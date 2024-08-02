using Entity.Goodjob;
using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 资讯文章的CRUD
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class NewsController : ControllerBase
    {
        private readonly INewsInfoService _news;
        public NewsController(INewsInfoService news)
        {
            _news = news;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="infoDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddNewsInfo([FromBody] InputBaseNewsInfoDto infoDto)
        {
            var result= await _news.AddBaseNewsInfo(infoDto);
            if (result.Result)
            {
                return Ok(new { code = 200, data=result.Message });
            }
            return Ok(new { code = 400, data = result.Message });
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetNewsInfo(int id)
        {
            var result = await _news.GetBaseNewsInfo(id);
            return Ok(new
            {
                code=200,
                data=result
            });
        }
        /// <summary>
        /// 获取文章列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetNewsInfos([FromQuery] BaseFilterModel baseFilter)
        {
            var result = await _news.GetBaseNewsInfos(baseFilter);
            return Ok(new
            {
                code = 200,
                data=new
                {
                    result.Count,
                    result.Item1
                }
               
            });
        }
        /// <summary>
        /// 修改文章
        /// </summary>
        /// <param name="infoDto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpNewsInfo([FromBody] OutBaseNewsInfoDto infoDto)
        {
            var result = await _news.UpBaseNewsInfo(infoDto);
            return Ok(new
            {
                code = 200,
                data = result
            });
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DelBaseNewsInfo(int id)
        {
            var result = await _news.DelBaseNewsInfo(id);
            if(result.Result)
            {
                return Ok(new { code = 200, data = result.Message });
            }
            return Ok(new { code = 400, data = result.Message });
        }
    }
}
