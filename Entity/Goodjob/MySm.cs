using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MySm
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime SentTime { get; set; }
    }
}
