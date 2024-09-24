using Microsoft.AspNetCore.Mvc;
using Iservice;
using Models;
using System.Net;
using AutoMapper;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 提供企业相关API
    /// </summary>
    [Route("api/[controller]/[action]")]
    //[ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public HomeController(ICompanyService iCompanyService, IMapper mapper)
        {
            _companyService = iCompanyService;
        }
        /// <summary>
        /// 返回就业驿站
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetStationList()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != null) 
            {
                var data = await _companyService.GetJiuYeStation(Convert.ToInt32(userId));
                return Ok(new { Code = 200, Data = data });
            }

            return Unauthorized();
            
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
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            Int32.TryParse(userId, out int loginId);
            if (loginId != 0)
            {
                var dt = await _companyService.AddRegisterUnemployment(input, tenantId, loginId);
                if (dt.Result)
                {
                    return Ok(new { Code = 200, Data =new {Msg="新增成功" } });
                }

                return Ok(new { Code = 400, Data = new { Msg = dt.Message } });
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

            if (dt.Result)
            {
                return Ok(new { Code = 200, Data = "更新成功" });
            }
            if(string.IsNullOrEmpty(dt.Message))
                return Ok(new { Code = 400, Data = "更新失败" });
            else
                return Ok(new { Code = 400, Data = dt.Message });
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

            IPAddress clientIp = HttpContext.Request.HttpContext.Connection.RemoteIpAddress;
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            Int32.TryParse(userId, out int loginId);
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


        /// <summary>
        /// 返回需要修改的企业信息
        /// </summary>
        /// <param name="memId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetData(int memId)
        {
            var s = await _companyService.GetData(memId);
            if (s == null)
                return NotFound("企业不存在");
            return Ok(new { Code = 200, Data = s });
            ;
        }

        /// <summary>
        /// 修改企业信息
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> UpdateInfo([FromForm] UpdateMemInfoJyDto info)
        {
            var title = User.Claims.FirstOrDefault(c => c.Type == "Title")?.Value;
            if (title == null)
            {
                return Unauthorized();
            }
            var s = await _companyService.Update(info, title);
            if (s.Result)
            {
                return Ok(new { Code = 200, Data = s.Message });
            }
            return NotFound("企业不存在");
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="modes"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdateAccount([FromForm] AccountModes modes)
        {
            var title = User.Claims.FirstOrDefault(c => c.Type == "Title")?.Value;
            if (title == null)
            {
                return Unauthorized();
            }
            var s = await _companyService.Update(modes, title);
            if (s.Result)
            {
                return Ok(new { Code = 200, Data = s.Message });
            }
            return NotFound("企业不存在");
        }
    }
}
