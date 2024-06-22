using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MySendResumeHistory
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string LetterContent { get; set; } = null!;
        public string OtherRequest { get; set; } = null!;
        public DateTime SendTime { get; set; }
        public bool IsDelete { get; set; }
    }
}
