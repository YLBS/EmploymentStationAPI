using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysAbnegate
    {
        public int AngId { get; set; }
        public string AngName { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}
