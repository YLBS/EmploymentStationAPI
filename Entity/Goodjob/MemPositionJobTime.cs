using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPositionJobTime
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public string JsonTime { get; set; } = null!;
        public int MemId { get; set; }
        public int JodDay { get; set; }
        public string JobWeek { get; set; } = null!;
        public string JobTime { get; set; } = null!;
        public string JobOther { get; set; } = null!;
    }
}
