using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyWorkExp
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string BeginDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public string ComName { get; set; } = null!;
        public byte ComType { get; set; }
        public int ComCalling { get; set; }
        public string PosName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string LeftReason { get; set; } = null!;
        public string ComIntroduction { get; set; } = null!;
        public byte ComSize { get; set; }
    }
}
