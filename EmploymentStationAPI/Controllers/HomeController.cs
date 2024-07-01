using Microsoft.AspNetCore.Mvc;
using Iservice;
using Models;
using Goodjob.Common.Dictionary;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Net;

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
        private readonly IJobService _jobService;
        public HomeController(ICompanyService iCompanyService, IOutDicService outDicService, IJwtService jwtService, IJobService jjobService)
        {
            _companyService = iCompanyService;
            _outDicService = outDicService;
            _jwtService = jwtService;
            _jobService = jjobService;
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
        /// 获取企业列表，Id等于0为全部，Id等于1为已通过，Id等于2为未通过,Id等于3为已发布，Name为关键字搜索
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCompanyList([FromQuery]BaseFilterModels baseFilter, int esId)
        {
            var list = await _companyService.GetOutMemInfoAsync(baseFilter,esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code=200,Data=new{ count, data } });
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
            var esIdStr = HttpContext.Request.Headers["esId"].ToString().Replace("", "");
            if (string.IsNullOrEmpty(esIdStr))
            {
                return BadRequest("esId 为空");
            }
            Int32.TryParse(esIdStr, out int esId);
            var list = await _companyService.GetUnemployment(tenantId, baseFilter, esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });
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
        /// <param name="input"></param>
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
        /// <summary>
        /// 返回人员信息列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUnemploymentInfoList([FromQuery]
            BaseFilterModels baseFilter,int esId)
        {
            var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            if (string.IsNullOrEmpty(tenantId))
            {
                return BadRequest(new { Code = 500, Data = "tenantId 为空" });
            }
            var list = await _companyService.GetOutUnemploymentInfoList(baseFilter, esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });
            
        }
        /// <summary>
        /// 获取失业人员信息
        /// </summary>
        /// <param name="myUserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUnemploymentInfo(int myUserId)
        {
            var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            if (string.IsNullOrEmpty(tenantId))
            {
                return BadRequest(new { Code = 500, Data = "tenantId 为空" });
            }
            var dt = await _companyService.GetOutUnemploymentInfo(myUserId);
            return Ok(new
            {
                Code = 200,
                Data = dt
            });
        }
        /// <summary>
        /// 修改失业人员信息
        /// </summary>
        /// <param name="unemployment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpUnemploymentInfo([FromBody]UpRegisterUnemploymentDto unemployment)
        {
            var dt = await _companyService.UpUnemploymentInfo(unemployment);

            if (dt)
            {
                return Ok(new { Code = 200, Data = "更新成功" });
            }
            return Ok(new { Code = 400, Data = "更新失败" });
        }
        /// <summary>
        /// 企业名称模糊查询
        /// </summary>
        /// <param name="memName"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMemInfoByName(string memName)
        {
            var dt = await _companyService.OutMemInfoByName(memName);
            return Ok(new { Code = 200, Data = dt });
        }

        /// <summary>
        /// 添加企业
        /// </summary>
        /// <param name="inputMemInfoJy"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddMemInfo([FromBody] InputMemInfoJyDto inputMemInfoJy)
        {
            var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            if (string.IsNullOrEmpty(tenantId))
            {
                return BadRequest("tenantId 为空");
            }
            IPAddress clientIp = HttpContext.Request.HttpContext.Connection.RemoteIpAddress;
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var data = _jwtService.ValidateToken(token);
            //int loginId;
            Int32.TryParse(data[1], out int loginId);
            // 将IP地址转换为字符串
            string clientIpAddress = clientIp?.ToString();

            var dt = await _companyService.AddMemInfo(inputMemInfoJy, tenantId, clientIpAddress, loginId);
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
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPositions(int memId)
        {
            var list = await _jobService.GetMemPositionList(memId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });
        }
        /// <summary>
        /// 获取职位信息
        /// </summary>
        /// <param name="posId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPositionInfo(int posId)
        {
            var list = await _jobService.GetMemPositionInfo(posId);
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
        /// 新增职位
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPosition([FromBody]InputPositionDto dto)
        {
            var dt = await _jobService.AddMemPosition(dto);
            if (dt.Result)
            {
                return Ok(new { Code = 200, Data = dt.Message });
            }
            return Ok(new { Code = 400, Data = dt.Message });
        }
        /// <summary>
        /// 获取招聘登记列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetRecruitmentRegister([FromQuery]
            BaseFilterModels baseFilter, int esId)
        {
            var list = await _companyService.GetRecruitmentRegister(baseFilter, esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });

        }
        /// <summary>
        /// 获取求职登记列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetApplytRegisterForJob([FromQuery]
            BaseFilterModels baseFilter, int esId)
        {
            var list = await _companyService.GetApplytRegisterForJob(baseFilter, esId);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code = 200, Data = new { count, data } });

        }
    }
}
