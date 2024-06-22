using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysDuty
    {
        public int DyId { get; set; }
        public string? DyName { get; set; }
        public string? Alias { get; set; }
        public string? Memo { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}
