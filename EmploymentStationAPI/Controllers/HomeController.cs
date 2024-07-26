using Microsoft.AspNetCore.Mvc;
using Iservice;
using Models;
using Goodjob.Common.Dictionary;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Net;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 提供企业相关API
    /// </summary>
    [Authorize]
    [Route("api/[controller]/[action]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IJwtService _jwtService;
        public HomeController(ICompanyService iCompanyService, IOutDicService outDicService, IJwtService jwtService, IJobService jobService)
        {
            _companyService = iCompanyService;
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
        /// 获取企业列表，Id等于0为全部，Id等于1为在招企业，Id等于2为未招企业，Name为关键字搜索
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId">驿站ID</param>
        /// <param name="beginDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCompanyList([FromQuery]BaseFilterModels baseFilter, int esId, string beginDate, string endDate)
        {
            var list = await _companyService.GetOutMemInfoAsync(baseFilter,esId, beginDate, endDate);
            var data = list.Item1;
            var count = list.Count;
            return Ok(new { Code=200,Data=new{ count, data } });
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
        /// 返回人员信息列表
        /// </summary>
        /// <param name="baseFilter"></param>
        /// <param name="esId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUnemploymentInfoList([FromQuery]
            BaseFilterModels baseFilter,int esId)
        {
            //var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            //if (string.IsNullOrEmpty(tenantId))
            //{
            //    return BadRequest(new { Code = 500, Data = "tenantId 为空" });
            //}
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
            //var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            //if (string.IsNullOrEmpty(tenantId))
            //{
            //    return BadRequest(new { Code = 500, Data = "tenantId 为空" });
            //}
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
        /// <param name="inputMemInfoJy">dto</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddMemInfo([FromBody] InputMemInfoJyDto inputMemInfoJy)
        {
            //var tenantId = HttpContext.Request.Headers["tenantId"].ToString().Replace("tenantId ", "");
            //if (string.IsNullOrEmpty(tenantId))
            //{
            //    return BadRequest("tenantId 为空");
            //}
            IPAddress clientIp = HttpContext.Request.HttpContext.Connection.RemoteIpAddress;
            var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var data = _jwtService.ValidateToken(token);
            //int loginId;
            Int32.TryParse(data[1], out int loginId);
            // 将IP地址转换为字符串
            string clientIpAddress = clientIp?.ToString();

            var dt = await _companyService.AddMemInfo(inputMemInfoJy, clientIpAddress, loginId);
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
