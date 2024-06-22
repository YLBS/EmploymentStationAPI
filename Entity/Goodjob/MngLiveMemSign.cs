using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveMemSign
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime SigDateTime { get; set; }
        public DateTime CreateTime { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string PosDes { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int? CheckFlag { get; set; }
        public DateTime? CheckDate { get; set; }
        public int? CheckUserId { get; set; }
        public bool? IsDel { get; set; }
        public bool? IsTop { get; set; }
        public string? Reason { get; set; }
        public int Lid { get; set; }
        public string? PosIds { get; set; }
        public int PosCount { get; set; }
    }
}
