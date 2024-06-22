using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class TaskQueue
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        /// <summary>
        /// 0 待执行 1执行中 2执行完成 3执行失败 
        /// </summary>
        public int TaskState { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime CreateTime { get; set; }
        public string TaskContent { get; set; } = null!;
        /// <summary>
        /// 0增1删2改3查4请求
        /// </summary>
        public int TaskType { get; set; }
        public string? TaskResult { get; set; }
        /// <summary>
        /// 请求地址
        /// </summary>
        public string? TaskUrl { get; set; }
        /// <summary>
        /// 请求数据包
        /// </summary>
        public string? TaskUrlData { get; set; }
    }
}
