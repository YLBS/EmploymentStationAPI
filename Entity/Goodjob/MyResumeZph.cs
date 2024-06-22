using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumeZph
    {
        public int MyUserId { get; set; }
        public int SchoolId { get; set; }
        public int GradeId { get; set; }
        public int DepartmentsId { get; set; }
        public int ClassId { get; set; }
        public int ProfessionalId { get; set; }
        public string UserName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public DateTime SignDateTime { get; set; }
        /// <summary>
        /// 短信发送时间
        /// </summary>
        public DateTime? SmssendTime { get; set; }
        /// <summary>
        /// 是否发送短信
        /// </summary>
        public bool HasSendSms { get; set; }
    }
}
