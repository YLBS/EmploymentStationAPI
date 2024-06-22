using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewPeiFileList
    {
        public int FileId { get; set; }
        public string FileNo { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string ShortMemo { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public byte FileType { get; set; }
        public DateTime InTime { get; set; }
        public int EplId { get; set; }
        public int InNumber { get; set; }
        public bool DelFlag { get; set; }
        public string PtypeName { get; set; } = null!;
        public string? Memo { get; set; }
        public string? ParentId { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
        public string? DptName { get; set; }
        public string ExpandType { get; set; } = null!;
    }
}
