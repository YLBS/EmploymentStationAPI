using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubInformationMy
    {
        public int InfoId { get; set; }
        public int MyUserId { get; set; }
        public int ClerkId { get; set; }
        public string Subject { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string Issuer { get; set; } = null!;
        public DateTime IssuedDate { get; set; }
        public bool Read { get; set; }
        public DateTime? ReadDate { get; set; }
        public bool? IsPublic { get; set; }
        public bool IsDelete { get; set; }
        public int Hits { get; set; }
        public int KeepDay { get; set; }
    }
}
