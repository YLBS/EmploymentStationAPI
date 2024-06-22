using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmModifyNameApply
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public string FComName { get; set; } = null!;
        public string TComName { get; set; } = null!;
        public string? FFax { get; set; }
        public string? FPhone { get; set; }
        public string? PhoneN { get; set; }
        public string? PhoneE { get; set; }
        public string? PhoneZ { get; set; }
        public string? FaxZ { get; set; }
        public string? FaxN { get; set; }
        public string? FaxE { get; set; }
        public int AEplId { get; set; }
        public DateTime ApplyDate { get; set; }
        public string AEplName { get; set; } = null!;
        public bool ModifyFlag { get; set; }
        public int MEplId { get; set; }
        public string MEplName { get; set; } = null!;
        public DateTime? ModifyDate { get; set; }
        public int ExamFlag { get; set; }
        public int EEplId { get; set; }
        public string EEplName { get; set; } = null!;
        public DateTime? ExamDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ExamStatus { get; set; } = null!;
        public string ModdifyStatus { get; set; } = null!;
        public bool Crmmodify { get; set; }
        public bool Webmodify { get; set; }
    }
}
