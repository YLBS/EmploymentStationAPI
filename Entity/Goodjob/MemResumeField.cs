using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemResumeField
    {
        public int Id { get; set; }
        public int? Location1 { get; set; }
        public int? Location2 { get; set; }
        public string? Rtext { get; set; }
        public bool? Rcheck { get; set; }
        public int? MemId { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
