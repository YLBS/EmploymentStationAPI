using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemLibDel
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public byte OldFlag { get; set; }
        public byte DelFrom { get; set; }
        public int OldRecordId { get; set; }
        public DateTime DelTime { get; set; }
    }
}
