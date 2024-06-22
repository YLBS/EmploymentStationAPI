using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewMenu
    {
        public int MnuId { get; set; }
        public int ParentId { get; set; }
        public int Depth { get; set; }
        public int Sequence { get; set; }
        public string MnuName { get; set; } = null!;
        public string? Alias { get; set; }
        public string? LnkUrl { get; set; }
        public string? Memo { get; set; }
        public short MnuType { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsBlank { get; set; }
    }
}
