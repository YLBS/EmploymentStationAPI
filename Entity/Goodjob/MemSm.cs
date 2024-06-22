using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSm
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Smscount { get; set; }
        public int SentSmscount { get; set; }
        public bool IsOpen { get; set; }
        public DateTime AddTime { get; set; }
        public bool IsDonation { get; set; }
    }
}
