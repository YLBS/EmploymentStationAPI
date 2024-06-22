using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPosDescriptionTemplate
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string Tite { get; set; } = null!;
        public string Posdescription { get; set; } = null!;
        public bool IsFig { get; set; }
    }
}
