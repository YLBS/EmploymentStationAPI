using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPhoto
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string Title { get; set; } = null!;
        public byte Type { get; set; }
        public string FilePath { get; set; } = null!;
        public bool Display { get; set; }
        public string? Memo { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
