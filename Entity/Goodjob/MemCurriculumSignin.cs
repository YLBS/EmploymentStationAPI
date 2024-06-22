using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemCurriculumSignin
    {
        public int Id { get; set; }
        public string MemName { get; set; } = null!;
        public int AppNumber { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string WxOpenId { get; set; } = null!;
        public DateTime? AddDateTime { get; set; }
        public int CId { get; set; }
        public DateTime SigninDate { get; set; }
        public bool IsSignin { get; set; }
        public string? MemAddress { get; set; }
        public string? ContactDepartment { get; set; }
        public bool? Isdell { get; set; }
        public string? SalerUserName { get; set; }
    }
}
