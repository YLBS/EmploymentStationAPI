using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemDepartment
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string DeptName { get; set; } = null!;
        public string Principal { get; set; } = null!;
        public string? Memo { get; set; }
        public string Email { get; set; } = null!;
        public bool DeptFlag { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
