using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngChat
    {
        public int Id { get; set; }
        public string? Record { get; set; }
        public int? SpokesmanId { get; set; }
        public bool? IsPass { get; set; }
        public int? LiveId { get; set; }
        public DateTime? AuditDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public string? Images { get; set; }
    }
}
