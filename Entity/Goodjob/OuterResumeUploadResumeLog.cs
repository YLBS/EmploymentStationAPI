using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 岗位上传简历记录
    /// </summary>
    public partial class OuterResumeUploadResumeLog
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        public int MyUserId { get; set; }
        public DateTime UploadDate { get; set; }
        /// <summary>
        /// 简历上传人ID
        /// </summary>
        public int UploadEplId { get; set; }
        /// <summary>
        /// 查看状态，0未读；1已读
        /// </summary>
        public int ViewFlag { get; set; }
    }
}
