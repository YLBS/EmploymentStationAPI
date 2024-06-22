using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class EmailSendResumeNotUpdated
    {
        public int MyUserId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime LockDate { get; set; }
        public byte SendEmailFlag { get; set; }
        public byte LockEmailFlag { get; set; }
        public string EncryptionStr { get; set; } = null!;
    }
}
