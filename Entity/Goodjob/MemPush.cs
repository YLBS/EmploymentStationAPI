using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPush
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PushType { get; set; }
        public int PushStatus { get; set; }
        public DateTime UpdateDateTime { get; set; }
        public string? RegistrationId { get; set; }
    }
}
