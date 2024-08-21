using Goodjob.Common.Dictionary;
using Iservice;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 提供相关数据
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class CorrelationController : ControllerBase
    {
        private readonly IOutDicService _outDicService;
        public CorrelationController(IOutDicService outDicService)
        {
            _outDicService = outDicService;
        }
        /// <summary>
        /// 获取学历列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetDegree()
        {
            var dt = await _outDicService.GetDicDegree();
            return Ok(new { Code = 200, Data = dt });
        }
        /// <summary>
        /// 获取职位类别List
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetJobList()
        {
            var dt = await _outDicService.GetDicJobDto();
            return Ok(new { Code = 200, Data = dt });
            //return Ok(new { Code = StatusCode(200), Data = dt });
        }
        /// <summary>
        /// 获取城市
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCityList(bool option)
        {
            var dt = await _outDicService.GetDicCity(option);
            return Ok(new { Code = 200, Data = dt });
        }
        /// <summary>
        /// 获取民族
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetNationList()
        {
            var d = ArrayResume.Nation;
            List<OutDicModels> outDic = new List<OutDicModels>();
            int i = 1;
            foreach (var item in d)
            {
                if (item != "")
                {
                    outDic.Add(new OutDicModels { Id = i, Name = item });
                    i++;
                }
            }
            //var data = await _outDicService.GetDicCity(option);
            return Ok(new
            {
                Code = 200,
                Data = outDic
            });
        }
        /// <summary>
        /// 获取证件类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCardTypeDictList()
        {
            var d = ArrayResume.CardType;
            //string json = JsonConvert.SerializeObject(d, Formatting.Indented);
            List<OutDicModels> outDic = new List<OutDicModels>();
            int i = 1;
            foreach (var item in d)
            {
                if (item != "")
                {
                    outDic.Add(new OutDicModels { Id = i, Name = item });
                    i++;
                }
            }
            //var data = await _outDicService.GetDicCity(option);
            return Ok(new
            {
                Code = 200,
                Data = outDic
            });
        }

        /// <summary>
        /// 返回行业列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMenInfoCalling()
        {
            var dt = await _outDicService.GetDicJobFunctionBig();
            return Ok(new { Code = 200, Data = dt });
        }
        /// <summary>
        /// 返回地区名称，详细到镇
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTowList()
        {
            var dt = await _outDicService.GetDicTown();
            return Ok(new { Code = 200, Data = dt });
        }
        /// <summary>
        /// 获取薪水列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetSalary()
        {
            var dt = await _outDicService.GetDicSalaryNew();
            return Ok(new { Code = 200, Data = dt });
            //return Ok(new{Code= StatusCode(200),Data=dt } );
        }
        /// <summary>
        /// 获取福利列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GeWelfaDict()
        {
            List<OutDicModels> outDics = new List<OutDicModels>();
            var welfs = Goodjob.Common.Dictionary.ArraryWelfa.WelfaDict;
            int wfg = welfs.Length / 2;
            OutDicModels outDic = new OutDicModels();
            for (int i = 0; i < wfg; i++)
            {
                OutDicModels outDic1 = new OutDicModels();
                outDic1.Id = Convert.ToInt32(welfs[i, 1]);
                outDic1.Name = welfs[i, 0];
                outDics.Add(outDic1);
            }
            outDic.Id = 48;
            outDic.Name = "大小周";
            outDics.Add(outDic);
            return Ok(new { Code = 200, Data = outDics });
        }
        /// <summary>
        /// 获取岗位标签
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPosLable()
        {
            var dt = await _outDicService.GetPosLable();
            return Ok(new { Code = 200, Data = dt });
        }
    }
}
