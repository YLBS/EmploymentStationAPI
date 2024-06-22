using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemWzph5
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string? Wtitle { get; set; }
        public string? Wdescribe { get; set; }
        public string Wurl { get; set; } = null!;
        public int BrowseCount { get; set; }
        public int VisitorCount { get; set; }
        public DateTime CreateDate { get; set; }
        public int Wzptype { get; set; }
        public string? WorKey { get; set; }
        public bool IsDell { get; set; }
        public string? Pic { get; set; }
        public DateTime? ExpireDate { get; set; }
        public bool? OpenMusic { get; set; }
    }
}
