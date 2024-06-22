using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClerkGoupInfo
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public string? ClerkName { get; set; }
        public string? PositimeInfo { get; set; }
        public int? Positime { get; set; }
        public string? AllSumInfo { get; set; }
        public int? AllSum { get; set; }
        public string? Remark { get; set; }
        public DateTime? Intime { get; set; }
        public string? ClerkInfo { get; set; }
    }
}
