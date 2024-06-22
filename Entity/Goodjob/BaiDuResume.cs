using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class BaiDuResume
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Cellphone { get; set; }
        public string? Birthday { get; set; }
        public string? JobArea { get; set; }
        public string? WorkYears { get; set; }
        public string? Education { get; set; }
        public string? Intention { get; set; }
        public string? HopeSalary { get; set; }
        public string? Email { get; set; }
        public string? Experience { get; set; }
        public string? ProfStatus { get; set; }
        public string? CoverLetter { get; set; }
        public string? Sex { get; set; }
        public string? JobCity { get; set; }
        public string? NoPrompt { get; set; }
        public string Uid { get; set; } = null!;
        public DateTime? Createtime { get; set; }
        public int MyUserId { get; set; }
        public int? CheckUid { get; set; }
        public string CheckName { get; set; } = null!;
        public int? Isdell { get; set; }
    }
}
