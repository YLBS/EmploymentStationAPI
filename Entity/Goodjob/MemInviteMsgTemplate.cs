using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemInviteMsgTemplate
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string MessageTemplate { get; set; } = null!;
    }
}
