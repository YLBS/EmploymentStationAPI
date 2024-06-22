using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubInformation
    {
        public int InfoId { get; set; }
        public int MemId { get; set; }
        public int SalerId { get; set; }
        public string Subject { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public byte IssuedFrom { get; set; }
        public DateTime IssuedDate { get; set; }
        public bool Read { get; set; }
        public string? Reader { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool IsDelete { get; set; }
        public int? PosType { get; set; }
    }
}
