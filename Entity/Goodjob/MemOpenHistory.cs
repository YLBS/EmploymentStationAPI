using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemOpenHistory
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public short MemberClass { get; set; }
        public DateTime BeginValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public int MaxPosNum { get; set; }
        public int MaxResumeNum { get; set; }
        public int SalerUserId { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool? Show { get; set; }
        public int UserId { get; set; }
        public string UserIp { get; set; } = null!;
    }
}
