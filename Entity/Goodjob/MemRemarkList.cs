using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemRemarkList
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public string MarkTitle { get; set; } = null!;
        public string MarkMemo { get; set; } = null!;
        public string MarkUser { get; set; } = null!;
        public DateTime? MarkDate { get; set; }
        public string? MarkImage { get; set; }
        public string? OpenId { get; set; }
    }
}
