using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PubInformation
    {
        public int InfoId { get; set; }
        public string? Heading { get; set; }
        public string Content { get; set; } = null!;
        public int TypeId { get; set; }
        public bool Important { get; set; }
        public int? KeepDay { get; set; }
        public int? IssuedDept { get; set; }
        public int? Issuer { get; set; }
        public DateTime? IssuedDate { get; set; }
        public int Publisher { get; set; }
        public DateTime PublishDate { get; set; }
        public int? Editor { get; set; }
        public DateTime? EditDate { get; set; }
        public int Hits { get; set; }
        public bool IsDelete { get; set; }

        public virtual PubInfoType Type { get; set; } = null!;
    }
}
