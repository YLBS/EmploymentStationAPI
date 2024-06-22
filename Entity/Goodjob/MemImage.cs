using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemImage
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string FileText { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string NewFileText { get; set; } = null!;
        public string NewFilePath { get; set; } = null!;
        public int OrderId { get; set; }
        public DateTime EditDate { get; set; }
        public int Type { get; set; }
        public int CheckStatus { get; set; }
        public DateTime CheckDate { get; set; }
        public bool Enabled { get; set; }
    }
}
