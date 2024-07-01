using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmploymentStationAPI.ExceptionFilter
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ExceptionFilter> logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            this.logger = logger;
        }
        public void OnException(ExceptionContext context)
        {
            // 创建一个错误响应
            var problemDetails = new ProblemDetails
            {
                Title = "请求发生错误",
                Status = StatusCodes.Status500InternalServerError,
                Detail = context.Exception.Message,
                Instance = context.Exception.StackTrace
            };

            // 设置结果
            context.Result = new ObjectResult(problemDetails)
            {
                StatusCode = problemDetails.Status
            };
            var logPath = Path.Combine(AppContext.BaseDirectory, "logs.txt");
            //logger.LogError("全局异常记录到Nlog日志==>" + context.Exception.Message);
            // 标记异常已经处理，以避免后续的过滤器处理
            context.ExceptionHandled = true;
        }
        //public Task OnExceptionAsync(ExceptionContext context)
        //{
        //    if (!context.ExceptionHandled)
        //    {
        //        context.Result = new ContentResult()
        //        {
        //            Content = "服务器异常请稍后再试...."
        //        };
        //        logger.LogError("全局异常记录到Nlog日志==>" + context.Exception.Message);
        //    }
        //    context.ExceptionHandled = true;
        //    return Task.CompletedTask;
        //}
    }
}
