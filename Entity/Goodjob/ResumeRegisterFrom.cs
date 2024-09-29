using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class ResumeRegisterFrom
    {
        public int Id { get; set; }
        public int FromId { get; set; }
        public int BelongType { get; set; }
        public string? Describe { get; set; }
    }
}
