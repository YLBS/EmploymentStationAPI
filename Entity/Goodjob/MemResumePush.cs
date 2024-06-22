using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 简历推送
    /// </summary>
    public partial class MemResumePush
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public DateTime InputDate { get; set; }
        public int HasPushed { get; set; }
        /// <summary>
        /// 推送简历ID
        /// </summary>
        public string PushMyUserIds { get; set; } = null!;
        public DateTime PushDate { get; set; }
    }
}
