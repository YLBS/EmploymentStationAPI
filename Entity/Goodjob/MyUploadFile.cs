using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyUploadFile
    {
        public int Id { get; set; }
        public int MyuserId { get; set; }
        public string Title { get; set; } = null!;
        public byte Type { get; set; }
        public string FilePath { get; set; } = null!;
        public byte Status { get; set; }
        public DateTime InsertDate { get; set; }
        public string Memo { get; set; } = null!;
        public int Goalcount { get; set; }
    }
}
