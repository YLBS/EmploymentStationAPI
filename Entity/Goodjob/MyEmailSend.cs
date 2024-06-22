using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyEmailSend
    {
        public int MyUserId { get; set; }
        public int SendCount { get; set; }
        public bool IsSendEmail { get; set; }
        public string EmailDirection { get; set; } = null!;
    }
}
