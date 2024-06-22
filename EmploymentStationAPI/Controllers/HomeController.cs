using Microsoft.AspNetCore.Mvc;
using Iservice;
using Models;
using Goodjob.Common.Dictionary;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace EmploymentStationAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IOutDicService _outDicService;
        private readonly IJwtService _jwtService;
        public HomeController(ICompanyService iCompanyService, IOutDicService outDicService, IJwtService jwtService)
        {
            _companyService = iCompanyService;
            _outDicService = outDicService;
            _jwtService = jwtService;
        }
        /// <summary>
        /// 返回就业驿站
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetStationList()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var dt = _jwtService.ValidateToken(token);
            //int loginId;
            Int32.TryParse(dt[1], out int loginId);
            var data = await _companyService.GetJiuYeStation(loginId);
            return Ok(new { Code = 200, Data = data });
        }
        /// <summary>
        /// 解析Token
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AnalysisToken()
        {
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var data = _jwtService.ValidateToken(token);
            return Ok(new { Code = 200, Data = data });
        }
        /// <summary>
        /// 获取人员列表,Id等于1为失业人员，Id等于2为退伍军人，Name为关键字搜索
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUnemployment([FromQuery] BaseFilterModels baseFilter)
        {
            var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            if (string.IsNullOrEmpty(tenantId))
            {
                return BadRequest("tenantId 为空");
            }
            var list = await _companyService.GetUnemployment(tenantId, baseFilter);
            var data = list.Item1;
            var count= list.Count;
            return Ok(new { Code = 200, Data =new { count, data } });
        }
        /// <summary>
        /// 获取企业列表，Id等于0为全部，Id等于1为已通过，Id等于2为未通过,Id等于3为已发布，Name为关键字搜索
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCompanyList([FromQuery]BaseFilterModels baseFilter)
        {
            var list = await _companyService.GetOutMemInfoAsync(baseFilter);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code=200,Data=new{ count, data } });
        }

        /// <summary>
        /// 获取职位信息
        /// </summary>
        /// <param name="memId">企业Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult>  GetPositionList(int memId)
        {
            var str = await _companyService.GetList(memId);
            return Ok(new { Code = 200, Data = str });
        }
        /// <summary>
        /// 失业登记
        /// </summary>
        /// <param name="input">输入</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddUnemployment([FromBody]InputRegisterUnemploymentDto input)
        {
            var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            if (string.IsNullOrEmpty(tenantId))
            {
                return BadRequest(new { Code = 500, Data = "tenantId 为空" });
            }
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var data = _jwtService.ValidateToken(token);
            //int loginId;
            Int32.TryParse(data[1], out int loginId);
            if (loginId != 0)
            {
                var dt = await _companyService.AddRegisterUnemployment(input, tenantId, loginId);
                if (dt)
                {
                    return Ok(new { Code = 200, Data =new {Msg="新增成功" } });
                }

                return Ok(new { Code = 400, Data = new { Msg = "新增失败" } });
            }
            return BadRequest(new {Code=403,Data= "Token过期" });
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
            //return Ok(new{Code= StatusCode(200),Data=dt } );
        }
        /// <summary>
        /// 获取职位List
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
                    outDic.Add(new OutDicModels { Id = i,Name = item });
                    i++;
                }
            }
            //var data = await _outDicService.GetDicCity(option);
            return Ok(new
            {
                Code=200,
                Data= outDic
            });
        }
        /// <summary>
        /// 证件类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCardTypeDictList()
        {
            var d = ArrayResume.CardType;
            //string json = JsonConvert.SerializeObject(d, Formatting.Indented);
            List<OutDicModels> outDic=new List<OutDicModels>();
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
    }
}
