using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemBackPassword
    {
        public int MemId { get; set; }
        public string EncryptionStr { get; set; } = null!;
        public DateTime SendTime { get; set; }
        public bool Flag { get; set; }
    }
}
