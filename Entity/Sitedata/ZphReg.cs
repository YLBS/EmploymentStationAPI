using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphReg
    {
        public int RegId { get; set; }
        public int Pid { get; set; }
        public string TrueName { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public string IdNumber { get; set; } = null!;
        public DateTime RegDate { get; set; }
        public string OpenId { get; set; } = null!;
        public string Grade { get; set; } = null!;
        public string Professional { get; set; } = null!;
        public string TheClass { get; set; } = null!;
        public string College { get; set; } = null!;
        public string StudentId { get; set; } = null!;
        public string JobString { get; set; } = null!;
        public string MemString { get; set; } = null!;
    }
}
