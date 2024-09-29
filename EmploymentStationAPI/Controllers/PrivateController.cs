using System.Runtime.InteropServices.ComTypes;
using Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace EmploymentStationAPI.Controllers
{
    /// <summary>
    /// 私有控制器,只有携带俊才网账户的token才能访问
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrivateController : ControllerBase
    {
        private IPrivateService privateService;
        public PrivateController(IPrivateService privateService)
        {
            this.privateService = privateService;
        }

        /// <summary>
        /// 获取驿站归属
        /// </summary>
        /// <param name="belongType">不传或传0 查全部</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetData(int belongType)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != "14")
                return Forbid();
            var result = await privateService.GetData(belongType);
            return Ok(new { Data1= result.list1,Data2 = result.list2 });
        }
        /// <summary>
        /// 添加驿站归属
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="name"></param>
        /// <param name="belongType"></param>
        /// <param name="fromId">用作添加到myUser表时登记来源，ResumeRegisterFrom</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AddEsBelongType(string dbName, string name, int belongType, int fromId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != "14")
                return Forbid();
            var s = await privateService.AddEsBelongType(dbName, name, belongType, fromId);
            return Ok(s);
        }
        /// <summary>
        /// 根据简历Id查看是属于哪个驿站的
        /// </summary>
        /// <param name="myUserId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetResume(int myUserId)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != "14")
                return Forbid();
            var s= await privateService.GetResume(myUserId);
            return Ok(s);
        }

        /// <summary>
        /// 删除驿站添加的失业人员信息
        /// </summary>
        /// <param name="myUserId"></param>
        /// <param name="belongType">驿站归属</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DelResume(int myUserId, int belongType)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (userId != "14")
                return Forbid();
            var yn= await privateService.DelResume(myUserId, belongType);
            if (yn)
                return Ok("删除成功");
            return Ok("简历不存在，或参数belongType错误");
        }

        /// <summary>
        /// 删除本驿站的企业信息，只是进行软删除，
        /// </summary>
        /// <param name="memId">企业Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DelMemInfo(int memId)
        {
            var title = User.Claims.FirstOrDefault(c => c.Type == "Title")?.Value;
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (title == null || userId == null)
            {
                return Unauthorized();
            }
            if (userId != "14")
                return Forbid();
            int.TryParse(userId, out int id);
            int i = await privateService.DelForJy(memId, title, id);
            if (i == 0)
                return NotFound("企业不存在就业驿站中");
            if (i == 1)
                return Ok(new { Code = 400, Data = "企业已是删除状态" });
            return Ok(new { Code = 200, Data = "删除成功" });
        }
        /// <summary>
        /// 移除删除，将企业设置为 未删除状态
        /// </summary>
        /// <param name="memId">企业Id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> RecoverMemInfo(int memId)
        {
            var title = User.Claims.FirstOrDefault(c => c.Type == "Title")?.Value;
            var userId = User.Claims.FirstOrDefault(c => c.Type == "UserId")?.Value;
            if (title == null || userId == null)
            {
                return Unauthorized();
            }
            if (userId != "14")
                return Forbid();
            int.TryParse(userId, out int id);
            int i = await privateService.RecoverMemInfo(memId, title, id);
            if (i == 0)
                return NotFound("企业不存在就业驿站中");
            return Ok(new { Code = 200, Data = "操作成功" });
        }

    }
}
