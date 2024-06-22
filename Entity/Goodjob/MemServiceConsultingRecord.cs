using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemServiceConsultingRecord
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public int ProblemType { get; set; }
        public string ProblemTypeName { get; set; } = null!;
        public DateTime CreateTime { get; set; }
        public string Massage { get; set; } = null!;
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
    }
}
