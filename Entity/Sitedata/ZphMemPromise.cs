using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphMemPromise
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Pid { get; set; }
        public int IsPromise { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpDate { get; set; }
        public bool IsViolation { get; set; }
        public string ViolationRemark { get; set; } = null!;
    }
}
