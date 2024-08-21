using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLinHuoYgRecord
    {
        public int Id { get; set; }
        public string MemName { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string ReferralCode { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
