using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 简历操作记录
    /// </summary>
    public partial class OuterResumeResumeOperationLog
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
        public string DptName { get; set; } = null!;
        public string OperationLog { get; set; } = null!;
        public DateTime OperationDate { get; set; }
    }
}
