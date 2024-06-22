using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewPeiComment
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public string? Comment { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? EplIp { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? Regtime { get; set; }
        public string FileNo { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string ShortMemo { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public byte FileType { get; set; }
        public string ExpandType { get; set; } = null!;
        public int EplId1 { get; set; }
        public int InNumber { get; set; }
        public bool DelFlag { get; set; }
        public DateTime Expr1 { get; set; }
        public string? PosName { get; set; }
        public int PosId { get; set; }
        public string EplName1 { get; set; } = null!;
        public string? Picture { get; set; }
    }
}
