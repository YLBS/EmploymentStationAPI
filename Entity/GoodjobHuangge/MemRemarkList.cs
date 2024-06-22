using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
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
    }
}
