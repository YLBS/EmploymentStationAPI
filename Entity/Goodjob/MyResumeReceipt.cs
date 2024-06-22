using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumeReceipt
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string MobileNum { get; set; } = null!;
        public DateTime MessageSendTime { get; set; }
        public bool HasBack { get; set; }
        public DateTime? BackTime { get; set; }
        public bool HasComplateed { get; set; }
    }
}
