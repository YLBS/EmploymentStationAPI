using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemUsersBack
    {
        public int MemId { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string LastLoginIp { get; set; } = null!;
        public short MemberClass { get; set; }
        public DateTime BeginValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public int MaxPosNum { get; set; }
        public int MaxResumeNum { get; set; }
        public int DateMaxViewNum { get; set; }
        public int DateViewedNum { get; set; }
        public int SumViewedNum { get; set; }
        public int AllSumViewed { get; set; }
        public byte CheckFlag { get; set; }
        public DateTime CheckDate { get; set; }
        public int CheckUserId { get; set; }
        public int SalerUserId { get; set; }
        public string SalerUserName { get; set; } = null!;
        public string SalerTel { get; set; } = null!;
        public string SalerEmail { get; set; } = null!;
        public int RegisterBy { get; set; }
        public int MaxHiresNum { get; set; }
        public int SumHires { get; set; }
    }
}
