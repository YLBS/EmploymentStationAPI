using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyPhoneDisabled
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int? MemId { get; set; }
        public DateTime SetDate { get; set; }
        public string DisabledPhone { get; set; } = null!;
        public bool HasDealWith { get; set; }
        public int DisabledList { get; set; }
        public string Contact { get; set; } = null!;
    }
}
